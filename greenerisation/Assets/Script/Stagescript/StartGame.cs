using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
    

        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("stage01");

            AudioSource audio = GetComponents<AudioSource>();
            audio.Play();

          
        }

        
    }

    
}