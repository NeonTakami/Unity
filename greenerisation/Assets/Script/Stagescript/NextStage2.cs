using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage2 : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    public void LoadNextLevel()
    {
        SceneManager.LoadScene("stage04"); ;
    }
    
    void OnTriggerEnter(Collider hit)
    {
        // When Player contacts "Danger"
        if (hit.CompareTag("Player"))
        {
            // Get scene index
            LoadNextLevel();
        }
    }
}