﻿using System.Collections;
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
            PlayerPrefs.SetString("Ground", "Ground");
            StartCoroutine(OpenInterfaceScreen(3));
        }
        if (collision.gameObject.name == "CylinderWater")
        {
            Debug.Log("Second level over");
            PlayerPrefs.SetString("Water", "Water");
            StartCoroutine(OpenInterfaceScreen(3));
        }
        if (collision.gameObject.name == "CylinderFire")
        {
            Debug.Log("First level over");
            PlayerPrefs.SetString("Fire", "Fire");
            StartCoroutine(OpenInterfaceScreen(3));
        }
    }
    IEnumerator OpenInterfaceScreen(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Interface");
    }


}
