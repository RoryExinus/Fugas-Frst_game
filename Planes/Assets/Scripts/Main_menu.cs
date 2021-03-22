using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("Game"); // game scene
    }

    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
