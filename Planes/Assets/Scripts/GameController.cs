using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public GameObject[] hazards;
    public Vector2 spawnValue;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float wavetWait;
    public bool restart;
    public bool gameOver;

    public Text End;
    public bool end;

    private void Start()
    {
        end = false;
        gameOver = false;
        restart = false;
        StartCoroutine (SpawnWaves());
    }
    private void Update()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(1);
                
            }
        }
    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(spawnWait);
        while(true){
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector2 spawnPosition = new Vector2(Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }

            yield return new WaitForSeconds(wavetWait);

            if (gameOver)
            {
                End.text = "Press R to restart game OR Press alt +f4 to exit";
                restart = true;
                end = true;
                break;
            }
        }
    }

    public void GameOver()
    {
        gameOver = true;
        end = true;

    }
}
