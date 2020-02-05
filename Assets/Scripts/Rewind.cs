using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rewind : MonoBehaviour
{
    bool isRewinding = false;

    public void ReverseGame()
    {
        if (isRewinding)
        {
            Time.timeScale = -1;
            isRewinding = false;
        }
        else
        {
            Time.timeScale = 0;
            isRewinding = true;
        }

    }
}

