﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovingTrigger : MonoBehaviour
{
    public PlatformMoving movingPlatform;

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.layer == 8 || other.gameObject.layer == 9))
        {
            movingPlatform.NextPlatform();
        }
    }
}
