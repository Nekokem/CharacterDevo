using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SpriteRendererControler : ScriptableObject
{
    [HideInInspector]
    public SpriteRenderer spriteRendererObj;

    public void StoreSpriteRenderer(SpriteRenderer spriteRenderer)
    {
        spriteRendererObj = spriteRenderer;
    }
}
