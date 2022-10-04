using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    void Update()
    {


        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("stage01");
            space();
        }

        public void space()
        {
            AudioSource audio = GetComponents<AudioSource>();
            audio.Play();
        }
    }


}