using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightScript : MonoBehaviour
{
    Light light;
    float flashlightTimer = 0f;
    float maxDuration = 20f;

    void Start()
    {
        light = GetComponent<Light>();
    }

    void Update()
    {
        // Toggle flashlight with F
        if (Input.GetKeyUp(KeyCode.F))
        {
            // timer enabled when on
            if (!light.enabled && flashlightTimer < maxDuration)
            {
                light.enabled = true;
            }
            else
            {
                light.enabled = false;
            }
        }

        if (light.enabled)
        {
            flashlightTimer += Time.deltaTime;

            // If the timer excedes the duration then turn off
            if (flashlightTimer >= maxDuration)
            {
                light.enabled = false;
            }
        }
    }
}
