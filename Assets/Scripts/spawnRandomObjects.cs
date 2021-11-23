using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class spawnRandomObjects : MonoBehaviour
{

    public GameObject randomObj1;
    public GameObject randomObj2;
    public GameObject randomObj3;
    public GameObject self;
    public Transform loc;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // private void onEnable(){
    //     print("Enabled");
    //     // Instantiate(spawnObj, loc.position, loc.rotation);
    // }

    // private void onDisable(){
    //     print("Disabled");
    // }

    // Update is called once per frame
    void Update()
    {
        if(self.activeSelf){
            // Random r = new Random();
            // int rInt = r.Next(0, 3); //for ints
            int rInt = Random.Range(0,3);
            print(rInt);
            if(rInt == 0) {
                Instantiate(randomObj1, loc.position, loc.rotation);
            }
            if(rInt == 1) {
                Instantiate(randomObj2, loc.position, loc.rotation);
            }
            if(rInt == 2) {
                Instantiate(randomObj3, loc.position, loc.rotation);
            }
            self.SetActive(false);
        }
        else{
            print("inactive");
        }
    }
}