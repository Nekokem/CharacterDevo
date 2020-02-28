using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorData : NameId
{
    public Color value = Color.blue;

    public void ChangeSpriteRendererColor(SpriteRenderer spriteRendererObj)
    {
        spriteRendererObj.color = value;
    }
    
    public void ChangeSpriteRendererColor(SpriteRendererControler spriteRendererControlerObj)
    {
        spriteRendererControlerObj.spriteRendererObj.color = value;
    }
}
