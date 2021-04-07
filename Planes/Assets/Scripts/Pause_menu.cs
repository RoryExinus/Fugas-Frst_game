using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Pause_menu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public void Menu()
    {
        SceneManager.LoadScene("Main_Menu"); // game scene
    }

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
                
                Pause();
            }
        }
        
        
            if (Input.GetKeyDown(KeyCode.Q))
            {

                    SceneManager.LoadScene("Main_Menu"); // game scene

            }

        
    }

    void Back()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }


}




