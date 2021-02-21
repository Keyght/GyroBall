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

    public Button ButtonGround;
    public Button ButtonWater;
    public Button ButtonFire;
    public Button ButtonWind;

    public Image ImageFirstRowBack;
    public Image ImageNature;

    public Button play;

    public string scene_name;
    // Start is called before the first frame update
    void Start()
    {
        ButtonGround.onClick.AddListener(whattodoground);
        ButtonWater.onClick.AddListener(whattodowater);
        ButtonFire.onClick.AddListener(whattodofire);
        ButtonWind.onClick.AddListener(whattodowind);
        play.onClick.AddListener(whattodoplay);
        scene_name = "scene";
    }
    public void whattodoground()
    {
        Debug.Log("Klicked ground");
        ImageFirstRowBack.GetComponent<Image>().color = new Color(96, 88, 86);
        HeaderNow.SetActive(false);
        FunctionsNow.SetActive(false);

        HeaderNext.SetActive(true);
        FunctionsNext.SetActive(true);

        scene_name = "StoneLoc";
    }
    public void whattodoplay()
    {
        SceneManager.LoadScene(scene_name);
    }
    public void whattodowater()
    {
        ImageFirstRowBack.color = new Color(0, 182, 222);
    }
    public void whattodofire()
    {
        ImageFirstRowBack.color = new Color(238, 128, 101);
    }
    public void whattodowind()
    {
        ImageFirstRowBack.color = new Color(160, 236, 252);
    }

    public void OnMouseDown()
    {
        
        if (gameObject.name=="ButtonGround")
        {
            Debug.Log("Klicked ground");
            ImageFirstRowBack.GetComponent<Image>().color = new Color(96, 88, 86, 255);
            ImageNature.GetComponent<Image>().sprite = Resources.Load<Sprite>("Assets/Textures/four-element5") as Sprite;
            HeaderNow.SetActive(false);
            FunctionsNow.SetActive(false);

            HeaderNext.SetActive(true);
            FunctionsNext.SetActive(true);
            scene_name = "StoneLoc";
        }
        if (gameObject.name == "ButtonWind")
        {
            Debug.Log("Klicked wind");
            ImageFirstRowBack.GetComponent<Image>().color = new Color(160, 236, 252, 255);
            ImageNature.GetComponent<Image>().sprite = Resources.Load<Sprite>("four-element4");
            HeaderNow.SetActive(false);
            FunctionsNow.SetActive(false);

            HeaderNext.SetActive(true);
            FunctionsNext.SetActive(true);
        }
        if (gameObject.name == "ButtonWater")
        {
            Debug.Log("Klicked water");
            ImageFirstRowBack.GetComponent<Image>().color = new Color(0, 182, 222, 255);
            ImageNature.GetComponent<Image>().sprite = Resources.Load<Sprite>("four-element3");
            HeaderNow.SetActive(false);
            FunctionsNow.SetActive(false);

            HeaderNext.SetActive(true);
            FunctionsNext.SetActive(true);
        }
        if (gameObject.name == "ButtonFire")
        {
            Debug.Log("Klicked fire");
            ImageFirstRowBack.GetComponent<Image>().color = new Color(238, 128, 101, 255);
            ImageNature.GetComponent<Image>().sprite = Resources.Load<Sprite>("four-element2");
            HeaderNow.SetActive(false);
            FunctionsNow.SetActive(false);

            HeaderNext.SetActive(true);
            FunctionsNext.SetActive(true);
        }
        if (gameObject.name == "ButtonPlay")
        {
            Debug.Log("Klicked play");
            SceneManager.LoadScene(scene_name);
        }
        Debug.Log("clicked");
    }
    //public void check (string scene_name)
    //{

    //}
    //void OnMouseDown()
    //{
    //    HeaderNow.SetActive(false);
    //    FunctionsNow.SetActive(false);

    //    HeaderNext.SetActive(true);
    //    FunctionsNext.SetActive(true);
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
