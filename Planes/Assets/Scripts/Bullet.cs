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
        if (collision.tag == "Box")
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
        

        Destroy(gameObject);
    }
}
