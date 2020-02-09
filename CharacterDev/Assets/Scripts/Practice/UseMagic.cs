using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseMagic : MonoBehaviour
{
    public ApplyForce magic;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(magic, transform.position, Quaternion.identity);

        }
        
    }
}
