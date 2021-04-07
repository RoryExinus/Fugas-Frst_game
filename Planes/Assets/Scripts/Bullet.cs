using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float dmg;

    public GameObject hitEffect;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.3f);
        if (collision.CompareTag("Box") || collision.CompareTag("Bullet"))
        {
            return;
        }
        if (collision.tag == "Asteroid")
        {
            AsteroidScript aster = collision.GetComponent<AsteroidScript>();
            aster.TakeDamage(dmg);

        }
        else if (collision.tag == "Enemy")
        {
            EnemyScript enemy = collision.GetComponent<EnemyScript>();
            enemy.TakeDamage(dmg);
        }
        else if (collision.tag == "Enemy Bullet")
        {
            Destroy(collision.gameObject);
        }
        

        Destroy(gameObject);
    }
}
