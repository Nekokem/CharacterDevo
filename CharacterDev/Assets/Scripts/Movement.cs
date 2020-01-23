using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{

    private Vector3 position;
    private CharacterController controller;

    public float moveSpeed = 30f, gravity = 9.8f, jumpSpeed = 50f;
    private int jumpCount;
    public int jumpCountMax = 2;
    
    /*public float controllerHeight = 50f;
    public bool controllerIsGrounded = true;
    public Vector3 controllerVelocity;*/
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");
        position.z = moveSpeed * Input.GetAxis("Vertical");
        position.y -= gravity;

        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax)
        {

            position.y = jumpSpeed;
            jumpCount++;

        }

        controller.Move(position * Time.deltaTime);
       
        /*controllerHeight = controller.height;
        controllerIsGrounded = controller.isGrounded;
        controllerVelocity = controller.velocity;
        controller.radius = 10f;
        controller.slopeLimit = 5f;
        controller.detectCollisions = true;
        controller.isTrigger = true;
        controller.skinWidth = 2f;
        controller.minMoveDistance = 20f;*/

    }
}
