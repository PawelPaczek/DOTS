using System;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

public partial class PlayerShootingSystem : SystemBase
{
    public event EventHandler OnShoot;

    protected override void OnCreate()
    {
        RequireForUpdate<Player>();
    }

    protected override void OnUpdate()
    {
        HandleStunToggle();
        HandleCubeSpawning();
    }

    private void HandleStunToggle()
    {
        Entity playerEntity = SystemAPI.GetSingletonEntity<Player>();

        if (Input.GetKeyDown(KeyCode.P))
        {
            SetPlayerStunned(playerEntity, true);
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            SetPlayerStunned(playerEntity, false);
        }
    }

    private void SetPlayerStunned(Entity playerEntity, bool isStunned)
    {
        EntityManager.SetComponentEnabled<Stunned>(playerEntity, isStunned);
    }

    private void HandleCubeSpawning()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;

        SpawnCubesConfig spawnCubesConfig = SystemAPI.GetSingleton<SpawnCubesConfig>();
        EntityCommandBuffer entityCommandBuffer = new EntityCommandBuffer(WorldUpdateAllocator);

        SpawnCubes(spawnCubesConfig, entityCommandBuffer);

        entityCommandBuffer.Playback(EntityManager);
    }

    private void SpawnCubes(SpawnCubesConfig spawnCubesConfig, EntityCommandBuffer entityCommandBuffer)
    {
        foreach ((RefRO<LocalTransform> localTransform, Entity entity) in SystemAPI.Query<RefRO<LocalTransform>>().WithAll<Player>()
                     .WithDisabled<Stunned>().WithEntityAccess())
        {
            Entity spawnedEntity = entityCommandBuffer.Instantiate(spawnCubesConfig.cubePrefabEntity);
            entityCommandBuffer.SetComponent(spawnedEntity, new LocalTransform
            {
                Position = localTransform.ValueRO.Position,
                Rotation = quaternion.identity,
                Scale = 1f
            });

            OnShoot?.Invoke(entity, EventArgs.Empty);
        }
    }

}