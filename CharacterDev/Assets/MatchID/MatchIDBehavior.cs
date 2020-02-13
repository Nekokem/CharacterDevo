using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchIDBehavior : MonoBehaviour
{
    public List<NameID> nameIds;
    private NameID otherIDObj;

    public List<DoWorks> DoWork;
    private void OnTriggerEnter(Collider other)
    {
        otherIDObj = other.GetComponent<BehaviorID>().nameIDObj;
        CheckID();
    }

    private void CheckID()
    {

        foreach (var obj in nameIds)
        {
            if (obj == otherIDObj)
            {
                foreach (var job in DoWork)
                {
                    job.Work();
                }
            }
        }
        
    }
}
