using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public float hp = 100f;
    public GameObject astroExplodeEffect;
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

    public void TakeDamage(float amount)
    {
        hp -= amount;
        if (hp <= 0)
        {
            GameObject effect = Instantiate(astroExplodeEffect, transform.position, transform.rotation);
            Destroy(effect, 0.3f);
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject effect = Instantiate(playerExplodeEffect, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            Destroy(effect, 0.3f);
            Destroy(gameObject);
            gm.GameOver();

           
        }
    }
}
