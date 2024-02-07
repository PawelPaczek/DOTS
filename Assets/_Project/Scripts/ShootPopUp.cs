using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPopUp : MonoBehaviour
{
    private float destroyTime = 1f;

    private void Update()
    {
        destroyTime -= Time.deltaTime;
        if (destroyTime <= 0f)
        {
            Destroy(gameObject, 2f);
        }
    }
}