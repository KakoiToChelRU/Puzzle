using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{   
    private void OnTriggerEnter(Collider other)
    {   
        if(other.CompareTag("Box") || other.CompareTag("Player")) Door._openDoor++;
    }
    private void OnTriggerExit(Collider other)
    {   
        if(other.CompareTag("Box") || other.CompareTag("Player")) Door._openDoor--;
    }
}
