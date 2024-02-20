using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.UIElements;

public partial struct PlayerMovementSystem : ISystem
{
    public void OnUpdate(ref SystemState state)
    {
        foreach (var (playerData, inputsData, transform) in SystemAPI
                     .Query<RefRO<Player>, RefRO<InputsData>, RefRW<LocalTransform>>())
        {
            transform.ValueRW.Position.x += inputsData.ValueRO.moveInput.x * playerData.ValueRO.speed * SystemAPI.Time.DeltaTime;
            transform.ValueRW.Position.z += inputsData.ValueRO.moveInput.y * playerData.ValueRO.speed * SystemAPI.Time.DeltaTime;
        }
    }
}