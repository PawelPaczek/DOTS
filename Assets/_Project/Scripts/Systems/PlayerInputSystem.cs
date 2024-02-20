using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public partial class PlayerInputSystem : SystemBase
{
    private MovementActions movementActions;
    
    protected override void OnCreate()
    {
        RequireForUpdate<Player>();

        movementActions = new MovementActions();
    }

    protected override void OnStartRunning()
    {
        movementActions.Enable();
    }

    protected override void OnUpdate()
    {
        foreach (RefRW<InputsData> data in SystemAPI.Query<RefRW<InputsData>>())
        {
            data.ValueRW.moveInput = movementActions.MovementMap.PlayerMovement.ReadValue<Vector2>();
        }
    }

    protected override void OnStopRunning()
    {
       movementActions.Disable();
    }
}
