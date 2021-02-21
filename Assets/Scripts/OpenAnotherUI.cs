using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    // Start is called before the first frame update
    void Start()
    {
        ButtonGround.onClick.AddListener(whattodoground);
        ButtonWater.onClick.AddListener(whattodowater);
        ButtonFire.onClick.AddListener(whattodofire);
        ButtonWind.onClick.AddListener(whattodowind);
    }
    public void whattodoground()
    {
        ImageFirstRowBack.GetComponent<Image>().color = new Color(96, 88, 86);
        HeaderNow.SetActive(false);
        FunctionsNow.SetActive(false);

        HeaderNext.SetActive(true);
        FunctionsNext.SetActive(true);
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
