using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform[] views;

    public float smoothSpeed = 10f;
    public Vector3 offset;
    Transform currentView;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Alpha1))
        {
            currentView = views[0];
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentView = views[1];
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentView = views[2];
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentView = views[3];
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            currentView = views[4];
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            currentView = views[5];
        }
    }
    
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * smoothSpeed);
    }
}
