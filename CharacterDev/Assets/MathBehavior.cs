using UnityEngine;

public class MathBehavior : MonoBehaviour
{
  public FloatData dataObj;
  public FloatData[] floatDataList;
  private NameId otherNameID;
  
  public void OnTriggerEnter(Collider other)
  {

    otherNameID = other.GetComponent<BehaviorID>().nameIDObj;
    ChangeValue();

  }

  public void ChangeValue()
  {
    
    foreach (var data in floatDataList)
    {
      if (data == otherNameID)
      {
        dataObj.UpdateValue(data.value);
      }
    }
    
  }
  
}
