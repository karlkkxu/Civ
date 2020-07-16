using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationTile : MonoBehaviour
{
    private int maxPop;

    public Vector3 GetLocation()
    {
        return this.transform.position;
    }
}
