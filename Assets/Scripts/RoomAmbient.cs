using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomAmbient : MonoBehaviour
{

    public AudioSource a1;
    public AudioSource a2;
    public AudioSource a3;
    public AudioSource a4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void playAudio(){
        if(!a1.isPlaying && !a2.isPlaying && !a3.isPlaying && !a4.isPlaying){
            int sound = Random.Range(0, 4);
            switch(sound){
                case 0:
                    a1.Play();
                    a1.volume = 0.07f;
                    break;
                case 1:
                    a2.Play();
                    a2.volume = 0.07f;
                    break;
                case 2:
                    a3.Play();
                    a3.volume = 0.07f;
                    break;
                case 3:
                    a4.Play();
                    a4.volume = 0.07f;
                    break;
                default:
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("playAudio", 10f, 60f);
    }
}
