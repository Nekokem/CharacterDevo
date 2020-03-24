using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Weapon : Collectible
{
    public UnityEvent useEvent;
    
    
    public override void Use()
    {
        useEvent.Invoke();
    }

    public void Attack()
    {
        Debug.Log("Attacked");
    }

    public void Equip()
    {
        
    }

    public void Upgrade()
    {
        
    }
    
}
