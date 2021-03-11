﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovment : MonoBehaviour
{
    public Rigidbody2D rb;
    public float spd = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right")) {
            rb.AddForce(new Vector3(spd, 0, 0));
        } else if (Input.GetKey("left")) {
            rb.AddForce(new Vector3(-spd, 0, 0));
        }
    }
}
