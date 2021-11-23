using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using TMPro;
using System;

public class DigitalTimeChanger : MonoBehaviour
{

    public int hour = 9;
    public int minute = 0;
    public string timeOfDay = "AM";
    public GameObject textMesh;
       
    // Start is called before the first frame update
    void Start()
    {
        //1 1.167
        InvokeRepeating("ChangeTime", 0.1f, 0.23f);

    }

    void ChangeTime(){
        if(minute == 59){
            minute = 0;

            if(hour+1 == 12){
                if(timeOfDay == "AM"){
                    timeOfDay = "PM";
                }
                else{
                    timeOfDay = "AM";
                }
            }
            
            if(hour+1 > 12){
                hour = 1;
            }
            else{
                hour++;
            }
        }
        else{
            minute++;
        }

        string minuteStr = minute.ToString();
        if(minute/10 == 0){
            minuteStr = "0" + minuteStr;
        }

        string time = hour.ToString() + ":" + minuteStr + timeOfDay;
        textMesh.GetComponent<TextMeshPro>().text = time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
