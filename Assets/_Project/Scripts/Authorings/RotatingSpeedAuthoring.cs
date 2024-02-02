using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class RotatingSpeedAuthoring : MonoBehaviour
{
    public float speedValue;

    public class Baker : Baker<RotatingSpeedAuthoring>
    {
        public override void Bake(RotatingSpeedAuthoring authoring)
        {
            Entity entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent(entity, new RotateSpeedValue
            {
                speedValue = authoring.speedValue
            });
        }
    }
}

public struct RotateSpeedValue : IComponentData
{
    public float speedValue;
}