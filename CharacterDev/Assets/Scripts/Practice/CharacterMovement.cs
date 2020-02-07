using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;

    private Vector3 position;

    public int walkSpeed = 100;
    public int jumpSpeed = 100;
    private float gravity = 9.8f;

    void Start()
    {
        GetComponent<CharacterController>();
    }

    void Update()
    {
        position.x = walkSpeed * Input.GetAxis("Horizontal");
        position.z = walkSpeed * Input.GetAxis("Vertical");
        position.y -= gravity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            position.y = jumpSpeed;
        }

        controller.Move(position * Time.deltaTime);
    }
}
