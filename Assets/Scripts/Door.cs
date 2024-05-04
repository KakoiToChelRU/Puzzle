using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{   public GameObject door;
    public string doorTag;
    private bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {   
        
        if(doorTag == "Door1"){
            if(isOpen == true){
                door.SetActive(false);
            }else if(isOpen == false){
                door.SetActive(true);
            }
        }
        
    }
}
