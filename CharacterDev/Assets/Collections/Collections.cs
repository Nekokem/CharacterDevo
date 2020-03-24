using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collections : ScriptableObject
{
    public List<Collectible> collectiblesList;
    public int currentCollectionNum;


    public void AddToCollection(Collectible collectibleObj)
    {
        if (collectiblesList.Contains(collectibleObj))
            return;
        collectiblesList.Add(collectibleObj);
    }

    public void RemoveFromCollection(Collectible collectibleObj)
    {
        for (var index = collectiblesList.Count - 1; index >= 0; index--)
        {
            var obj = collectiblesList[index];
            if (obj == collectibleObj)
            {
                collectiblesList.Remove(collectibleObj);
            }
        }
    }

    public void ClearCollection()
    {
        collectiblesList.Clear();
    }

    public void UseCurrentItem()
    {
        if (collectiblesList.Capacity > 0)
        {
            collectiblesList[currentCollectionNum].Use();

        }
        
    }

    public void IncrementCurrentNum()
    {
        if (currentCollectionNum > collectiblesList.Count - 1)
        {
            currentCollectionNum++;
        }
        else
        {
            currentCollectionNum = 0;
        }
    }
}
