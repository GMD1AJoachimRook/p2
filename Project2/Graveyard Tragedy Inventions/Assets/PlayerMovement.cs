﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject player;

    public float moveSpeed;
    public float turnSpeed;

    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * turnSpeed * Time.deltaTime);
        mainCamera.transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y"), 0, 0) * turnSpeed * Time.deltaTime);
    }
}

