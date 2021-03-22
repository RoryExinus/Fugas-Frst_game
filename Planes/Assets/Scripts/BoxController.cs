using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    public GameObject box;
    public Vector2 spawnValue;
    public int boxCount;
    public float spawnWait;
    private void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(spawnWait);
        while (boxCount >= 0)
        {
            Vector2 spawnPosition = new Vector2(Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(box, spawnPosition, spawnRotation);
            boxCount--;
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
