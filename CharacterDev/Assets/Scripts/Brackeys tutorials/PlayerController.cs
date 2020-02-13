using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    private Camera cam;
    private PlayerMotor motor;
    
    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            Debug.Log("We hit it.");
            if (Physics.Raycast(ray, out hit))
            {
                motor.MoveToPoint(hit.point);
                
                // stop focus any objs
            }
        }
    }
}
