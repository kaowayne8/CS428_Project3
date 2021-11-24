using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{

    public void doPrimaryAction()
    {

        // if we are grabbing flashlight other actions should take priority
        if (GrabbedManager.Instance.flashLightGrabbed)
        {
                swapFlashLightSource();
        }

    }


    // swap the flash light on and off
    public void swapFlashLightSource()
    {
        // find flash light and get its spotlight, and the front of the flash light
        GameObject flash = GameObject.Find("HandLampModel");

        GameObject light = flash.transform.GetChild(1).gameObject;

        // if the light is active, turn it off and swap the material on the
        // front of flash light
        if (light.activeSelf)
        {
            light.SetActive(false);
        }
        // do the opposite
        else
        {
            light.SetActive(true);
        }
    }
}
