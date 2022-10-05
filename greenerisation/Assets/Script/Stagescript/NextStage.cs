using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene("stage02");
    }
    
    
    void OnTriggerEnter(Collider hit)
    {
        // When Player contacts "Danger"
        if (hit.CompareTag("Player"))
        {
            LoadNextLevel();
        }
    }
}