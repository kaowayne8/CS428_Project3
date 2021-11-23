using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MakeCoffee : MonoBehaviour
{

    public GameObject spawnObj;
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
            print("active");
            Instantiate(spawnObj, loc.position, loc.rotation);
            self.SetActive(false);
        }
        else{
            print("inactive");
        }
    }
}
