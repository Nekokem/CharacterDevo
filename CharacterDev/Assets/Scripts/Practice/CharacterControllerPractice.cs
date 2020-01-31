using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterControllerPractice : MonoBehaviour
{
    private CharacterController Controller;

    public float speed = 8.0f;
    public float jumpSpeed = 6.0f;
    public float gravity = 10.0f;
    
    private Vector3 moveDirection = Vector3.zero;
    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        if (Controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;
        }

        if (Input.GetButton("Jump"))
        {
            moveDirection.y = jumpSpeed;
        }

        moveDirection.y = gravity * Time.deltaTime;
    }
    
}
