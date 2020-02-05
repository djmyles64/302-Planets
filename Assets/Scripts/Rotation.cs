using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float degrees = 90;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
        Vector3 axis = new Vector3(0, degrees, degrees);

        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, axis, Time.deltaTime);
    }
}
