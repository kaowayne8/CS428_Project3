using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuckooScript : MonoBehaviour
{

    public GameObject bell;
    float position = 0;
    int direction = 1;  //0 for left, 1 for right
    int offset = 15;
    int max_swing = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if going right
        if(direction == 1){
            if(position > max_swing){
                direction = 0;
                offset = offset * -1;
            }
        }
        else{   //going left
            if(position < -1*max_swing){
                direction = 1;
                offset = offset * -1;
            }
        }
        

        //rotate and update position
        position += offset*Time.deltaTime;
        bell.transform.Rotate(0,offset*Time.deltaTime, 0);

    }
}
