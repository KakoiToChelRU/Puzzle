using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{   public static int openDoor;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        openDoor = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    
        
        private void OnCollisionEnter(Collision collision)
    {
    if (collision.collider.CompareTag("Box"))
        {
            openDoor = 1;
            anim.SetTrigger("Punch");
            Debug.Log("Box");
        }else
        {
            openDoor = 0;
            
        }
}
     
      
}
