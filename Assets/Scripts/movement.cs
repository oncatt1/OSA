using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    public Camera playerCamera;
    public float moveSpeed = 6f;
    public float gravity = 10f;
    public float lookSpeed = 2f;
    public float rotationSpeed = 180f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += moveSpeed * Time.deltaTime * -transform.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            float rotationThisFrame = rotationSpeed;
            transform.Rotate(0, 0, rotationThisFrame);
        }
        if (Input.GetKey(KeyCode.D))
        {
            float rotationThisFrame = rotationSpeed;
            transform.Rotate(0, 0, -rotationThisFrame);
        }

    }
}