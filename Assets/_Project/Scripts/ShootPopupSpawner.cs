using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public class ShootPopupSpawner : MonoBehaviour
{
    [SerializeField] private GameObject shootPopupPrefab;

    private void Start()
    {
        PlayerShootingSystem playerShootingSystem =
            World.DefaultGameObjectInjectionWorld.GetExistingSystemManaged<PlayerShootingSystem>();

        playerShootingSystem.OnShoot += PlayerShootingSystemOnShoot;
    }

    private void PlayerShootingSystemOnShoot(object sender, System.EventArgs e)
    {
        Entity playerEntity = (Entity)sender;
        LocalTransform localTransform =
            World.DefaultGameObjectInjectionWorld.EntityManager.GetComponentData<LocalTransform>(playerEntity);
        Instantiate(shootPopupPrefab, localTransform.Position, Quaternion.identity);
    }
}