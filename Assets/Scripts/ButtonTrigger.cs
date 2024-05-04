using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{   
    public string button;
    public static string buttonTag;
    public static int isOpen;
    public int Open;
    public Animator anim;
    public GameObject door;
    public string doorTag;
    public string nameButton;
    public string buttons;
    public bool PlayerCan;
    public bool button1;
    public bool button2;
    public bool BoxCan;
    private void OnTriggerEnter(Collider other)
    {   
        if(button == "room1"){
        if(PlayerCan == true){
            if(other.CompareTag("Player"))
            {   if(anim != null){
            anim.SetTrigger("Punch");
            }
            
            
            doorTag = "Door1";
            isOpen = 1;
            }
        }
        if(other.CompareTag("Box"))
        {   if(anim != null){
            anim.SetTrigger("Punch");
            }
            
            
            
            isOpen = 1;
        }
        }else if (button == "room2"){
        if(PlayerCan == true){
            if(other.CompareTag("Player"))
            {   if(anim != null){
            anim.SetTrigger("Punch");
            }
            
            
            doorTag = "Door2";
            isOpen = 2;
            }
        }
        if(other.CompareTag("Box"))
        {   if(anim != null){
            anim.SetTrigger("Punch");
            }
            
            
            
            isOpen = 2;
        }
        }else if (button == "room3"){
        if(PlayerCan == true){
            if(other.CompareTag("Player"))
            {   if(anim != null){
            anim.SetTrigger("Punch");
            }
            
            
            doorTag = "Door3";
            isOpen = 3;
            }
        }
        if(BoxCan == true){
        if(other.CompareTag("Box"))
            {   if(anim != null){
            anim.SetTrigger("Punch");
                }
            
            
            
                isOpen = 3;
                }
        }
        }
        if(buttons == "room3.1"){
            if(isOpen == 3){
                button1 = true;
            }else{
                button1 = false;
            }
            
        }else if (buttons == "room3.2"){
            if(isOpen == 3){
                button2 = true;
            }else{
                button2 = false;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {   if(button == "room1"){
        if(other.CompareTag("Box"))
        {   if(anim != null){
            anim.SetTrigger("Punch");
            }
            
            
            isOpen = 0;
        }else
        {
        
        }
        }else if(button == "room2"){
        
        }
    }
    // Start is called before the first frame update
    void Start()
    {   
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
    if(doorTag == "Door1"){
            if(isOpen == 1){
                door.SetActive(false);
            }else{
                door.SetActive(true);
            }
        }
        if(doorTag == "Door2"){
            if(isOpen == 2){
                door.SetActive(false);
            }else{
                door.SetActive(true);
            }
        }
        if(doorTag == "Door3"){
            if(button1 == true && button2 == true){
                door.SetActive(false);
            }else{
                door.SetActive(true);
            }
        }
        Open = isOpen;
        buttonTag = button;
        
    }
}
