using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{   public Animator anim;
    public int room;
    public string button2;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
           
           
            if(anim != null){
                if(room == 12){
                    room = 21;
                    anim.SetInteger("Room", 12);
                }else if(room == 21){
                    room = 12;
                    anim.SetInteger("Room", 21);
                }else if(room == 23){
                
                    room = 32;
                    anim.SetInteger("Room", 23);
                }else if(room == 34){
                    room = 43;
                    anim.SetInteger("Room", 34);
                }else if(room == 32){
                    room = 23;
                    anim.SetInteger("Room", 32);
                }else if(room == 43){
                    room = 34;
                    anim.SetInteger("Room", 43);
                }
            
            Debug.Log("Player");
            
            
           }
        }
    }
    void Start()
    {
        anim.SetBool("Room1", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
