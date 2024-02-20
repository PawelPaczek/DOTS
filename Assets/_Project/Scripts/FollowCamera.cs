using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private float3 offset = new float3(0f, 3.5f, -5f);
    
    private void Start()
    {

    }

    private void UpdateCameraPosition(float3 position)
    {
        transform.position = position + offset;
    }

    private void OnDisable()
    {
        
    }
}