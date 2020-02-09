using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class ApplyForce : MonoBehaviour
{
    private Rigidbody rigBody;
    public Vector3Data forceDirection;
    public float force = 3f;
    
    void Start()
    {
        rigBody = GetComponent<Rigidbody>();
        rigBody.AddForce(forceDirection.value*force);

    }

    private void OnCollisionEnter(Collision other)
    {
        
    }
}
