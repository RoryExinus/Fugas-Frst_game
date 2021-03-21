using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject hazard;
    public Vector2 spawnValue;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float wavetWait;
    private void Start()
    {
        StartCoroutine (SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(spawnWait);
        while(true){
            for (int i = 0; i < hazardCount; i++)
            {
                Vector2 spawnPosition = new Vector2(Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(wavetWait);
        }
    }
}
