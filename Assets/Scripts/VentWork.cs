using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentWork : MonoBehaviour
{
    public GameObject wind_plane1;
    public GameObject wind_plane2;
    public GameObject wind_plane3;
    public GameObject wind_plane4;
    public GameObject wind_plane5;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name=="Vent")
        {
            wind_plane1.SetActive(true);
        }
        if (collision.gameObject.name == "Vent002")
        {
            wind_plane2.SetActive(true);
        }
        if (collision.gameObject.name == "Vent004")
        {
            wind_plane3.SetActive(true);
        }
        if (collision.gameObject.name == "Vent006")
        {
            wind_plane4.SetActive(true);
        }
        if (collision.gameObject.name == "Vent008")
        {
            wind_plane5.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
