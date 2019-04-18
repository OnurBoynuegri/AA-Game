using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaCember : MonoBehaviour
{
    public GameObject dartoku;
    GameObject OyunYoneticisi;
    void Start()
    {
        OyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisitag");
    }
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            DartOkuOlustur();
        }
    }
    void DartOkuOlustur()
    {
        Instantiate(dartoku, transform.position, transform.rotation);
        OyunYoneticisi.GetComponent<Oyunyoneticisi>().KalanDart();
    }
}
