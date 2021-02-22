using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfASession : MonoBehaviour
{
    public GameObject FinishCanvas;
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
        }
    }
    IEnumerator OpenInterfaceScreen(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Interface");
    }


}
