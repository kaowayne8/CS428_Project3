using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class to keep track of what items are being held in the scene
public class GrabbedManager : MonoBehaviour
{
    // create a singleton
    public static GrabbedManager Instance { get; private set; }

    // booleans to track which objects are grabbed
    public bool flashLightGrabbed = false;

    // assign singleton
    void Start()
    {
        Instance = this;
    }

    // set flashLightGrabbed to true
    public void activateFlashGrab()
    {
        flashLightGrabbed = true;
    }

    // set flashLightGrabbed to false
    public void deactivateFlashGrab()
    {
        flashLightGrabbed = false;
    }

}
