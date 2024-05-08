using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalPlayer : MonoBehaviour
{
    public GameObject Portal;
    public bool PlayerCan;
    public bool BoxCan;
    // Start is called before the first frame update
    void Start()
    {
       
       
    }
    private void OnTriggerEnter(Collider other)
    {  
       if((other.CompareTag("Player") && PlayerCan) || (other.CompareTag("Box") && BoxCan)){
       other.transform.position = Portal.transform.position;
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
