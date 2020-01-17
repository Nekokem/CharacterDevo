using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDChecker : MonoBehaviour
{
    public List<NameID> IDNameObj;

    private void OnTriggerEnter(Collider other)
    {
        var nameIDObj = other.GetComponent<BehaviorID>().IdNameOBJ;

        if (nameIDObj == null)
            return;
        
        foreach (var nameId in IDNameObj)
        {
            if (nameId == nameIDObj)
            {
                print("found!");
                break;
            }
        }
    }
}
