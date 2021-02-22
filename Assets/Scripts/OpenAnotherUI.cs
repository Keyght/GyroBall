using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenAnotherUI : MonoBehaviour
{
    public GameObject HeaderNow;
    public GameObject HeaderNext;
    public GameObject FunctionsNow;
    public GameObject FunctionsNext;

    public GameObject canvas_ui;

    public Button ButtonGround;
    public Button ButtonWater;
    public Button ButtonFire;
    public Button ButtonWind;

    public Image ImageFirstRowBack;
    public Image ImageNature;

    public GameObject WaterCastle;
    public GameObject FireCastle;
    public GameObject WindCastle;

    public Button play;

    public string scene_name;
    public Text scene_name_text;


    public void Awake()
    {
       // DontDestroyOnLoad(canvas_ui);
    }

    void Start()
    {
        ButtonWater.interactable = false;
        ButtonFire.interactable = false;
        ButtonWind.interactable = false;
        if (PlayerPrefs.HasKey("Ground"))
        {
            Debug.Log("Water available");
            WaterCastle.SetActive(false);
            ButtonWater.interactable = true;
        }
        if (PlayerPrefs.HasKey("Water"))
        {
            Debug.Log("Fire available");
            FireCastle.SetActive(false);
            ButtonFire.interactable = true;
        }
        if (PlayerPrefs.HasKey("Fire"))
        {
            Debug.Log("Wind available");
            WindCastle.SetActive(false);
            ButtonWind.interactable = true;
        }
    }
    void Update()
    {
       
    }

    public void OnMouseDown()
    {
        if (gameObject.name=="ButtonGround")
        {
            Debug.Log("Klicked ground");
            ImageFirstRowBack.GetComponent<Image>().color = new Color(0.3764706f, 0.345098f, 0.3372549f, 1f);
            ImageNature.GetComponent<Image>().sprite = Resources.Load<Sprite>("four-element5") as Sprite;
            HeaderNow.SetActive(false);
            FunctionsNow.SetActive(false);

            HeaderNext.SetActive(true);
            FunctionsNext.SetActive(true);

            scene_name = "StoneLoc";
            scene_name_text.text = scene_name;
            Debug.Log("UITEkst"+ scene_name_text.text);

        }
        if (gameObject.name == "ButtonWind")
        {
            Debug.Log("Klicked wind");
            ImageFirstRowBack.GetComponent<Image>().color = new Color(0.627451f, 0.9254903f, 0.9882354f, 1f);
            ImageNature.GetComponent<Image>().sprite = Resources.Load<Sprite>("four-element4") as Sprite;
            HeaderNow.SetActive(false);
            FunctionsNow.SetActive(false);

            HeaderNext.SetActive(true);
            FunctionsNext.SetActive(true);
            scene_name = "WindLoc";
            scene_name_text.text = scene_name;
        }
        if (gameObject.name == "ButtonWater")
        {
            Debug.Log("Klicked water");
            ImageFirstRowBack.GetComponent<Image>().color = new Color(0f, 0.7137255f, 0.8705882f, 1f);
            ImageNature.GetComponent<Image>().sprite = Resources.Load<Sprite>("four-element3") as Sprite;
            HeaderNow.SetActive(false);
            FunctionsNow.SetActive(false);

            HeaderNext.SetActive(true);
            FunctionsNext.SetActive(true);
            scene_name = "WaterLoc";
            scene_name_text.text = scene_name;
        }
        if (gameObject.name == "ButtonFire")
        {
            Debug.Log("Klicked fire");
            ImageFirstRowBack.GetComponent<Image>().color = new Color(0.9333334f, 0.5019608f, 0.3960785f, 1f);
            ImageNature.GetComponent<Image>().sprite = Resources.Load<Sprite>("four-element2") as Sprite;
            HeaderNow.SetActive(false);
            FunctionsNow.SetActive(false);

            HeaderNext.SetActive(true);
            FunctionsNext.SetActive(true);
            scene_name = "FireLoc";
            scene_name_text.text = scene_name;
        }
        if (gameObject.name == "ButtonPlay")
        {
            SceneManager.LoadScene(scene_name_text.text);
            Debug.Log("But2" + scene_name);
        }
        Debug.Log("clicked");
    }

}
