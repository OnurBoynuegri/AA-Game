using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dartokuKod : MonoBehaviour
{
    Rigidbody2D fizik;
    private int hiz = 15;
    bool hareketkontrol = true;
    GameObject oyunyoneticisi;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        oyunyoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisitag");
    }
    
    void FixedUpdate()
    {
        if (hareketkontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
            // nesnenin yukarı hareket etmesini sağlar.vector2.up yerine "new vector2(0,1);" bu kod da olabilirdi
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="donencembertag")
        {
            transform.SetParent(collision.transform);
            //çarpışmanın olduğu yerdeki nesnenin alt nesnesi olur yani çebner dartın ata classı olur. 
            hareketkontrol = false;
        }
        if (collision.tag == "dartokutag")
        {
            oyunyoneticisi.GetComponent<Oyunyoneticisi>().GameOver();
        }
    }
}
