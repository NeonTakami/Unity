using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame1 : MonoBehaviour
{
    void Update()
    {


        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("stage01");
        }


    }


}