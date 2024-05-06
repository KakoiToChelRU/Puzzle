using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{ 
    public GameObject door;
    public static int _openDoor;
    [SerializeField] int _button;
    void Update()
    {   
        if(_button <= _openDoor) door.SetActive(false);
        else door.SetActive(true);
    }
}

