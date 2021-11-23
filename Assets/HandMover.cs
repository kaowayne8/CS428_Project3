using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMover : MonoBehaviour
{

    public GameObject bigHand;
    public GameObject smallHand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bigHand.transform.Rotate(0,-24*Time.deltaTime, 0); 
        smallHand.transform.Rotate(0,-2*Time.deltaTime, 0); 
    }
}
