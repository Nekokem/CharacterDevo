using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChanger : MonoBehaviour
{
    public Light myLight;

    public void OnTriggerEnter(Collider other)
    {
        myLight.color = Color.red;
    }
}
