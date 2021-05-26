using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndOfASession : MonoBehaviour
{
    public GameObject FinishCanvas;
    public GameObject FinishCanvasGood;

    public GameObject NowSphere;
    public GameObject NextSphere;
    public GameObject EmptySphere;

    Rigidbody now_Rigidbody;
    Rigidbody next_Rigidbody;

    public float timerValue = 0f;

    public bool isGameFinished;
    public Text TimerText;

    void Start()
    {
        //gameOverTimerText = GameObject.Find("TimerText").GetComponent<Text>();

        now_Rigidbody = NowSphere.GetComponent<Rigidbody>();
        next_Rigidbody = NextSphere.GetComponent<Rigidbody>();
        next_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
    }
    void Update()
    {
        UpdateTimer();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Floor")) {
            isGameFinished = true;
            FinishCanvas.SetActive(true);
            TimerText = GameObject.Find("TimerText").GetComponent<Text>();
            TimerText.text = "Время прохождения: "+FormatTime(timerValue);
            StartCoroutine(OpenInterfaceScreen(3));
            Debug.Log("Hit");
        }
        if (collision.gameObject.name== "Cylinder12")
        {
            Debug.Log("First level over");
            PlayerPrefs.SetString("Ground", "Ground");
            NextSphere.transform.position = NowSphere.transform.position;
            now_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
            isGameFinished = true;
            FinishCanvasGood.SetActive(true);
            TimerText = GameObject.Find("TimerText").GetComponent<Text>();
            TimerText.text = "Время прохождения: " + FormatTime(timerValue);
            NowSphere.GetComponent<MeshRenderer>().material = NextSphere.GetComponent<MeshRenderer>().material;
            StartCoroutine(OpenInterfaceScreen(3));
        }

        if (collision.gameObject.name == "CylinderWater")
        {
            Debug.Log("Second level over");
            PlayerPrefs.SetString("Water", "Water");
            NextSphere.transform.position = NowSphere.transform.position;
            now_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
            isGameFinished = true;
            FinishCanvasGood.SetActive(true);
            TimerText = GameObject.Find("TimerText").GetComponent<Text>();
            TimerText.text = "Время прохождения: " + FormatTime(timerValue);
            NowSphere.GetComponent<MeshRenderer>().material = NextSphere.GetComponent<MeshRenderer>().material;
            StartCoroutine(OpenInterfaceScreen(3));
        }
        if (collision.gameObject.name == "CylinderFire")
        {
            Debug.Log("Third level over");
            PlayerPrefs.SetString("Fire", "Fire");
            NextSphere.transform.position = NowSphere.transform.position;
            now_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
            isGameFinished = true;
            FinishCanvasGood.SetActive(true);
            TimerText = GameObject.Find("TimerText").GetComponent<Text>();
            TimerText.text = "Время прохождения: " + FormatTime(timerValue);
            NowSphere.GetComponent<MeshRenderer>().material = NextSphere.GetComponent<MeshRenderer>().material;
            StartCoroutine(OpenInterfaceScreen(3));
        }
        if (collision.gameObject.name == "CylinderWind")
        {
            Debug.Log("Last level over");
            PlayerPrefs.SetString("Wind", "Wind");
            NextSphere.transform.position = NowSphere.transform.position;
            now_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
            isGameFinished = true;
            FinishCanvasGood.SetActive(true);
            TimerText = GameObject.Find("TimerText").GetComponent<Text>();
            TimerText.text = "Время прохождения: " + FormatTime(timerValue);
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

    void UpdateTimer()
    {
        if (isGameFinished) return;
        timerValue += Time.deltaTime;
    }

    string FormatTime(double unformatted)
    {
        int rounded = (int)Math.Round(unformatted);
        return AddLeadingZero(rounded / 3600) + ":"
               + AddLeadingZero(rounded / 60) + ":"
               + AddLeadingZero(rounded % 60);
    }
    string AddLeadingZero(int n)
    {
        if (n < 10)
            return "0" + n.ToString();
        else
            return n.ToString();
    }


}
