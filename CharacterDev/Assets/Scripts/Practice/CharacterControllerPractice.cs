using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

[RequireComponent(typeof(CharacterController))]
public class CharacterControllerPractice : MonoBehaviour
{
   public CharacterController controller;
   private Vector3 position;

   public int speed = 30;
   public int jumpSpeed = 10;
   private float gravity = 9.8f;

   void Start()
   {
       GetComponent<CharacterController>();
   }

   void Update()
   {
       position.x = speed * Input.GetAxis("Horizontal");
       position.z = speed * Input.GetAxis("Vertical");
       position.y -= gravity;

       if (Input.GetKeyDown(KeyCode.Space))
       {
           position.y = jumpSpeed;
       }

       controller.Move(position * Time.deltaTime);
   }
}
