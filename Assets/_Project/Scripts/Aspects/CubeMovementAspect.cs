using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public readonly partial struct CubeMovementAspect : IAspect
{
    public readonly RefRW<LocalTransform> localTransform;
    public readonly RefRO<RotateSpeedValue> rotateSpeedValue;
    public readonly RefRO<Movement> movement;

    public void MoveAndRotate(float deltaTime)
    {
        localTransform.ValueRW = localTransform.ValueRO.RotateY(rotateSpeedValue.ValueRO.speedValue * deltaTime);
        localTransform.ValueRW = localTransform.ValueRO.Translate(movement.ValueRO.movementVector * deltaTime);
    }
}