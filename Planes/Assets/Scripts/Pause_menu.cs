using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Pause_menu : MonoBehaviour
{


    public static bool GameIsPaused = false;
    


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Back();
            }
            else
            {
                Paus();
            }
        }    
    }

    void Back()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Paus()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }



}




