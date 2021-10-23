using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_cap : MonoBehaviour
{
    void Awake()
    {
#if UNITY_EDITOR

        QualitySettings.vSyncCount = 0; // VSync must be disabled.
        Application.targetFrameRate = 144;
#endif
    }
}
