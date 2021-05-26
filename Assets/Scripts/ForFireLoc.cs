using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForFireLoc : MonoBehaviour
{
    public GameObject Fire1;
    public GameObject Fire2;
    public GameObject Fire3;

    public GameObject Prep1;
    public GameObject Prep2;
    public GameObject Prep3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("top"))
        {
            Fire1.SetActive(true);
            StartCoroutine(DestroyFirstPrep(3));
            Debug.Log("top");
        }
        else if (collision.gameObject.name.Contains("top001"))
        {
            Fire2.SetActive(true);
            StartCoroutine(DestroySecondPrep(3));
            Debug.Log("top001");
        }
        else if (collision.gameObject.name.Contains("top002"))
        {
            Fire3.SetActive(true);
            StartCoroutine(DestroyThirdPrep(3));
            Debug.Log("top002");
        }
    }
    IEnumerator DestroyFirstPrep(float time)
    {
        yield return new WaitForSeconds(time);
        Prep1.SetActive(false);
    }
    IEnumerator DestroySecondPrep(float time)
    {
        yield return new WaitForSeconds(time);
        Prep2.SetActive(false);
    }
    IEnumerator DestroyThirdPrep(float time)
    {
        yield return new WaitForSeconds(time);
        Prep3.SetActive(false);
    }
}
