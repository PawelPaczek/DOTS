using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

public class VectorAddition : MonoBehaviour
{
    private void Start()
    {
        int length = 100000;

        NativeArray<float> vectorA = InitializeVector(length);
        NativeArray<float> vectorB = InitializeVector(length, true);
        NativeArray<float> result = new NativeArray<float>(length, Allocator.TempJob);

        PerformAddition(vectorA, vectorB, result);

        PrintResults(result);

        DisposeArrays(vectorA, vectorB, result);
    }

    private NativeArray<float> InitializeVector(int length, bool isB = false)
    {
        NativeArray<float> vector = new NativeArray<float>(length, Allocator.TempJob);
        for (int i = 0; i < length; i++)
        {
            vector[i] = isB ? i * 2 : i;
        }

        return vector;
    }

    private void PerformAddition(NativeArray<float> vectorA, NativeArray<float> vectorB, NativeArray<float> result)
    {
        AddVectorsJob addJob = new AddVectorsJob
        {
            VectorA = vectorA,
            VectorB = vectorB,
            Result = result
        };

        JobHandle jobHandle = addJob.Schedule(result.Length, 64);
        jobHandle.Complete();
    }

    private void PrintResults(NativeArray<float> result)
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log($"Result[{i}] = {result[i]}");
        }
    }

    private void DisposeArrays(NativeArray<float> vectorA, NativeArray<float> vectorB, NativeArray<float> result)
    {
        vectorA.Dispose();
        vectorB.Dispose();
        result.Dispose();
    }
}

[BurstCompile]
public struct AddVectorsJob : IJobParallelFor
{
    [ReadOnly] public NativeArray<float> VectorA;
    [ReadOnly] public NativeArray<float> VectorB;
    [WriteOnly] public NativeArray<float> Result;

    public void Execute(int i)
    {
        Result[i] = VectorA[i] + VectorB[i];
    }
}