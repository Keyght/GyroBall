using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfASession : MonoBehaviour
{
    public GameObject FinishCanvas;
    public GameObject FinishCanvasGood;

    public GameObject NowSphere;
    public GameObject NextSphere;
    public GameObject EmptySphere;

    Rigidbody now_Rigidbody;
    Rigidbody next_Rigidbody;
    void Start()
    {
        now_Rigidbody = NowSphere.GetComponent<Rigidbody>();
        next_Rigidbody = NextSphere.GetComponent<Rigidbody>();
        next_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Floor")) {
            FinishCanvas.SetActive(true);
            StartCoroutine(OpenInterfaceScreen(3));
            Debug.Log("Hit");
        }
        if (collision.gameObject.name== "Cylinder12")
        {
            Debug.Log("First level over");
            PlayerPrefs.SetString("Ground", "Ground");
            NextSphere.transform.position = NowSphere.transform.position;
            now_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
            FinishCanvasGood.SetActive(true);
            NowSphere.GetComponent<MeshRenderer>().material = NextSphere.GetComponent<MeshRenderer>().material;
            StartCoroutine(OpenInterfaceScreen(3));
        }

        if (collision.gameObject.name == "CylinderWater")
        {
            Debug.Log("Second level over");
            PlayerPrefs.SetString("Water", "Water");
            NextSphere.transform.position = NowSphere.transform.position;
            now_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
            FinishCanvasGood.SetActive(true);
            NowSphere.GetComponent<MeshRenderer>().material = NextSphere.GetComponent<MeshRenderer>().material;
            StartCoroutine(OpenInterfaceScreen(3));
        }
        if (collision.gameObject.name == "CylinderFire")
        {
            Debug.Log("Third level over");
            PlayerPrefs.SetString("Fire", "Fire");
            NextSphere.transform.position = NowSphere.transform.position;
            now_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
            FinishCanvasGood.SetActive(true);
            NowSphere.GetComponent<MeshRenderer>().material = NextSphere.GetComponent<MeshRenderer>().material;
            StartCoroutine(OpenInterfaceScreen(3));
        }
        if (collision.gameObject.name == "CylinderWind")
        {
            Debug.Log("Last level over");
            PlayerPrefs.SetString("Wind", "Wind");
            NextSphere.transform.position = NowSphere.transform.position;
            now_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
            FinishCanvasGood.SetActive(true);
            NextSphere.SetActive(true);
            //NowSphere.GetComponent<MeshRenderer>().material = NextSphere.GetComponent<MeshRenderer>().material;
            NowSphere.GetComponent<MeshRenderer>().material = EmptySphere.GetComponent<MeshRenderer>().material;
            StartCoroutine(OpenInterfaceScreen(3));
        }
    }
    IEnumerator OpenInterfaceScreen(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Interface");
    }


}
