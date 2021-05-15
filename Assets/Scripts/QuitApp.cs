using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApp : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Canvas2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseDown()
    {
        if (gameObject.name == "Quit")
        {
            Canvas.SetActive(false);
            Canvas2.SetActive(true);
        }
        if (gameObject.name == "ButtonYes")
        {
            Application.Quit();
        }
        if (gameObject.name == "ButtonNo")
        {
            Canvas.SetActive(true);
            Canvas2.SetActive(false);
        }

    }
}
