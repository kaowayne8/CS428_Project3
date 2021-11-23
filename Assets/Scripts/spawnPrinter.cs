using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPrinter : MonoBehaviour
{

    public GameObject spawnObj;
    public GameObject self;
    public Transform loc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(self.activeSelf){
            Instantiate(spawnObj, loc.position, loc.rotation);
            self.SetActive(false);
            print("Spawn Notebook");
        }
        else{
            print("inactive");
        }
    }
}
