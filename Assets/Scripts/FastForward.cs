using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastForward : MonoBehaviour
{
    bool isFast = false;

    public void SpeedUpGame()
    {
        if (isFast)
        {
            Time.timeScale = 1;
            isFast = false;
        }
        else
        {
            Time.timeScale = 3;
            isFast = true;
        }

    }
}

