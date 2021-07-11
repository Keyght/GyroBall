using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForFireLoc : MonoBehaviour
{
    public GameObject FinishCanvas;

    public GameObject NowSphere;
    public GameObject WaterSphere;

    public GameObject Fire1;
    public GameObject Fire2;
    public GameObject Fire3;
    public GameObject Fire4;

    public GameObject Fire5_1;
    public GameObject Fire5_2;
    public GameObject Fire5_3;
    public GameObject Fire5_4;

    public GameObject Prep1;
    public GameObject Prep2;
    public GameObject Prep3;
    public GameObject Prep4;

    public GameObject Prep_seno;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("top000"))
        {
            Fire1.SetActive(true);
            StartCoroutine(DestroyFirstPrep(3));
            Debug.Log("top000");
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
        else if (collision.gameObject.name.Contains("Paper"))
        {
            Fire4.SetActive(true);
            StartCoroutine(DestroyFourthdPrep(3));
            Debug.Log("Paper");
        }
        else if (collision.gameObject.name.Contains("stock"))
        {
            Fire5_1.SetActive(true);
            StartCoroutine(RunSecondAndFourthFireSeno(1));
            Debug.Log("Seno_1");
        }
        if (collision.gameObject.name.Contains("Water"))
        {
            //FinishCanvas.SetActive(true);
            Debug.Log("Hit water");
            //MeshCollider[] colliders = FindObjectsOfType<MeshCollider>();
            //int len = colliders.Length;
            //for (int i = 0; i < len; i++) {
            //    if (colliders[i].name.Contains("Water"))
            //    {
            //        GameObject.Destroy(colliders[i]);
            //    }    
            //}
            Destroy(collision.gameObject.GetComponent<MeshCollider>());
            NowSphere.GetComponent<MeshRenderer>().material = WaterSphere.GetComponent<MeshRenderer>().material;
            StartCoroutine(OpenInterfaceScreen(3));


        }
    }
    IEnumerator DestroyFirstPrep(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(Prep1);
        Destroy(Fire1);
    }
    IEnumerator DestroySecondPrep(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(Prep2);
        Destroy(Fire2);
    }
    IEnumerator DestroyThirdPrep(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(Prep3);
        Destroy(Fire3);
    }
    IEnumerator DestroyFourthdPrep(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(Prep4);
        Destroy(Fire4);
    }
    IEnumerator RunSecondAndFourthFireSeno(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("Seno2_4");
        Fire5_2.SetActive(true);
        Fire5_3.SetActive(true);
        StartCoroutine(RunThirdFireSeno(1));
    }
    IEnumerator RunThirdFireSeno(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("Seno3");
        Fire5_4.SetActive(true);
        StartCoroutine(DestroySenoAndFire(3));
    }
    IEnumerator DestroySenoAndFire(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("Destroy seno");
        Destroy(Prep_seno);
        Destroy(Fire5_1);
        Destroy(Fire5_2);
        Destroy(Fire5_3);
        Destroy(Fire5_4);
    }
    IEnumerator OpenInterfaceScreen(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Interface");
    }
}
