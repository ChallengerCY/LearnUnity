using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationBackgroundLoadingPriority : MonoBehaviour
{
    private void Start()
    {
        Example1();
    }

    void Example1()
    {
        // Load as much data as possible, as a result frame rate will drop.
        // Good for fast loading when showing progress bars.

        Application.backgroundLoadingPriority = ThreadPriority.High;
    }

    void Example2()
    {
        // Load data very slowly and try not to affect performance of the game.
        // Good for loading in the background while the game is playing.

        Application.backgroundLoadingPriority = ThreadPriority.Low;
    }
}
