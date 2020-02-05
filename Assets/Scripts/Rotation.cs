using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        float degrees = 90;
        Vector3 to = new Vector3(degrees, 0, 0);

        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
    }
}
