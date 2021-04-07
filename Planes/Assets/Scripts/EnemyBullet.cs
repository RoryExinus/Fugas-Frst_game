using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject playerExplodeEffect;

    private GameController gm;

    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gm = gameControllerObject.GetComponent<GameController>();
        }
        else
        {
            Debug.Log("GameControer = null");
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject effect = Instantiate(playerExplodeEffect, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            Destroy(effect, 0.3f);
            Destroy(gameObject);
            gm.GameOver();
        }
        else if(collision.CompareTag("Box"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        
    }
}
