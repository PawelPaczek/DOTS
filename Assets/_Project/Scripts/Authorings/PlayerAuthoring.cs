using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class PlayerAuthoring : MonoBehaviour
{
    public float speed = 2f;
    
    public class Baker : Baker<PlayerAuthoring>
    {
        public override void Bake(PlayerAuthoring authoring)
        {
            Entity entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent(entity, new Player
            {
                speed = authoring.speed
            });
            
            AddComponent(entity, new InputsData
            {
                
            });
        }
    }
}

public struct Player : IComponentData
{
    public float speed;
}