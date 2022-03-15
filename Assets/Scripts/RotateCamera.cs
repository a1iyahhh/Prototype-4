﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    private Rigidbody playerRb;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
       playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
     void Update()
    {
         float horizontalInput = Input.GetAxis("Horizontal");
         transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
