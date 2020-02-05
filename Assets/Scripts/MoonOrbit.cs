using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonOrbit : MonoBehaviour
{
    public Transform moonOrbitCenter;
    public float orbitSpeed = 10;
    public float magnitude = 0.5f;

    void Start()
    {
        
    }

    
    void Update()
    {

        

        float angle = Time.time;
        //float mag = 0.5f;

        Vector3 pos = (moonOrbitCenter == null) ? Vector3.zero : moonOrbitCenter.position;

        pos.x += Mathf.Cos(angle * orbitSpeed) * magnitude;
        pos.z += Mathf.Sin(angle * orbitSpeed) * magnitude;



        transform.position = pos;
    }
}
