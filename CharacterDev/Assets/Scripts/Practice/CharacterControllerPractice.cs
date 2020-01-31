using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterControllerPractice : MonoBehaviour
{
    private Vector3 position;
    private CharacterController controller;

    public float speed = 10f;
    public float gravity = 10f;
    public float jumpSpeed = 20f;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        position.x = speed * Input.GetAxis("Horizontal");
        position.z = speed * Input.GetAxis("Vertical");
        position.z -= gravity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            position.y = jumpSpeed;
        }
    }
    
}
