using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAndMatchID : MonoBehaviour
{

    public NameID nameIDObj;
    
    private void OnTriggerEnter(Collider other)
    {
        var otherNameID = other.GetComponent<ObjectAndMatchID>().nameIDObj;
        if (nameIDObj == null) return;
        var otherNameId = nameIDObj;
        if (nameIDObj == otherNameID)
        {
         //do work   
        }
    }
}
