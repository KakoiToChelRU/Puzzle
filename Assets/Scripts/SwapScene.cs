using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {   
        if(other.CompareTag("Player")) LoadNextLevel();
        Door._openDoor = 0;
        PlayerControl._numRoom = 1;
    }
    void LoadNextLevel()
    {
        int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
        int nextLevelIndex = currentLevelIndex + 1;

        if(nextLevelIndex == SceneManager.sceneCountInBuildSettings) nextLevelIndex = 0;
        SceneManager.LoadScene(nextLevelIndex);
    } 
}
