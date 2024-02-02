using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class RotateSpeedAuthoring : MonoBehaviour
{
  public float speedValue;
  
  private class Baker: Baker<RotateSpeedAuthoring>
  {
    public override void Bake(RotateSpeedAuthoring authoring)
    {
        
      Entity entity = GetEntity(TransformUsageFlags.Dynamic);
      AddComponent(entity,new RotateSpeed
      {
        speedValue = authoring.speedValue
      });
      
    }
  }
}

public struct RotateSpeed : IComponentData
{
  public float speedValue;
}

