using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using System;

public class Jump : MonoBehaviour
{
    public StarterAssetsInputs sa;
    private float t = 0f;

    private void Update()
    {
        if(sa.jump == true)
        {
            JumpStart();
        }
    }

    private void JumpStart()
    {
        t += Time.deltaTime;

        if(t > 0.5f)
        {
            sa.jump = false;
            t = 0f;
        }
    }
}
