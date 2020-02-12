using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMe : MonoBehaviour
{

    public Transform positionA;
    public Transform positionB;
    
    [Range(0, 1)] public float percent;

    public float animationTime = 2;
    float animationTimeCurrent = 0;
    bool isPlayingForward = true;

    public AnimationCurve curve;


    Vector3 currentEaseTarget;

    void Start()
    {

    }


    void Update()
    {

        if (isPlayingForward)
        {
            animationTimeCurrent += Time.deltaTime; // add time
            if (animationTimeCurrent > animationTime) isPlayingForward = false; // start playing backwards
        }
        else
        {
            animationTimeCurrent -= Time.deltaTime; // subtract time
            if (animationTimeCurrent < 0) isPlayingForward = true; // start playing forwards
        }

        percent = animationTimeCurrent / animationTime;


        CalcPosition();
    }

    void OnValidate()
    {
        CalcPosition();
    }

    /// <summary>
    /// This function calculates the final position
    /// of this object between two specified locations.
    /// </summary>
    void CalcPosition()
    {
        if (positionA == null) return;
        if (positionB == null) return;


        float p = curve.Evaluate(percent);


        // find target position:
        currentEaseTarget = AnimMath.Lerp(positionA.position, positionB.position, p);
        

        // ease towards target:
        transform.position = AnimMath.Dampen(transform.position, currentEaseTarget, .05f);
    }

}
