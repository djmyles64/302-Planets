using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonOrbit : MonoBehaviour
{
    public Transform moonOrbitCenter;

    void Start()
    {
        
    }

    
    void Update()
    {
        float angle = Time.time;
        float mag = 2;

        Vector3 pos = (moonOrbitCenter == null) ? Vector3.zero : moonOrbitCenter.position;

        pos.x += Mathf.Cos(angle) * mag;
        pos.z += Mathf.Sin(angle) * mag;



        transform.position = pos;
    }
}
