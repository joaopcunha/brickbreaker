﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickLife : MonoBehaviour
{
    // Start is called before the first frame update

    public float life = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (life <= 0) {
            Destroy(this.gameObject);
        }
    }
}
