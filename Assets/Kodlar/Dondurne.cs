﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dondurne : MonoBehaviour
{
    public float hiz;
    void Update()
    {
        transform.Rotate(0,0,hiz*Time.deltaTime);        
    }
}
