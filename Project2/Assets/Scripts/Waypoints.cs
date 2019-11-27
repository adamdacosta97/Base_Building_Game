using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Transform[] points;
    
    //populate the array with the transforms of the waypoints tranforms
    void Awake()
    {
        points = new Transform[transform.childCount];
        for (int i = 0; i < points.Length; i += 1)
        {
            points[i] = transform.GetChild(i);
        }
    }
}
