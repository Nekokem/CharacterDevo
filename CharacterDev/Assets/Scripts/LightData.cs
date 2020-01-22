using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class LightData : ScriptableObject
{
    public Light lightObj;
    public UnityEvent lightEvent;
    public ScriptableObject OnTrigStay;


}
