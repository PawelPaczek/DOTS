using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public partial struct RotatingCubeSystem : ISystem
{
    public void OnCreate(ref SystemState state)
    {
        
    }

    public void OnUpdate(ref SystemState state)
    {
        foreach ((RefRW<LocalTransform> localTransform, RefRO<RotateSpeed> rotateSpeed) in SystemAPI.Query<RefRW<LocalTransform>,RefRO<RotateSpeed>>())
        {
            localTransform.ValueRW = localTransform.ValueRO.RotateY(rotateSpeed.ValueRO.speedValue * SystemAPI.Time.DeltaTime);
        }
    }

    public void OnDestroy(ref SystemState state)
    {
        
    }
}