using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public partial struct RotatingCubeSystem : ISystem
{
    public void OnCreate(ref SystemState state)
    {
        state.RequireForUpdate<RotateSpeed>();
    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        // foreach ((RefRW<LocalTransform> localTransform, RefRO<RotateSpeed> rotateSpeed) in SystemAPI.Query<RefRW<LocalTransform>, RefRO<RotateSpeed>>())
        // {
        //     float power = 1f;
        //     for (int i = 0; i < 100000; i++)
        //     {
        //         power *= 2f;
        //         power /= 2f;
        //     }
        //
        //     localTransform.ValueRW = localTransform.ValueRO.RotateY(rotateSpeed.ValueRO.speedValue * SystemAPI.Time.DeltaTime * power);
        // }

        RotatingCubeJob rotatingCubeJob = new RotatingCubeJob
        {
            deltaTime = SystemAPI.Time.DeltaTime
        };
        
        rotatingCubeJob.ScheduleParallel();
    }

    public void OnDestroy(ref SystemState state)
    {
    }
    
    [BurstCompile]
    public partial struct RotatingCubeJob : IJobEntity
    {
        public float deltaTime;

        //ref - is read/write
        //in - is read only

        public void Execute(ref LocalTransform localTransform, in RotateSpeed rotateSpeed)
        {
            float power = 1f;
            for (int i = 0; i < 100000; i++)
            {
                power *= 2f;
                power /= 2f;
            }

            localTransform = localTransform.RotateY(rotateSpeed.speedValue * deltaTime * power);
        }
    }
}