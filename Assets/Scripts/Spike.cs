using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{   
    public bool fire;
    public bool killPlayer;
    // Start is called before the first frame update
    
    
    public void OnCollisionEnter(Collision other)
    {  if(killPlayer == true){
       if(other.collider.CompareTag("Player")){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        }
        if(fire == true){
        if(other.collider.CompareTag("Box")){
        if(other != null){
        Destroy(other.gameObject);
        }
        }
        }
    }
    // Update is called once per frame
    
}
