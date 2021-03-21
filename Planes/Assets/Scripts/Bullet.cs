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
        AsteroidScript aster = collision.GetComponent<AsteroidScript>();
        aster.TakeDamage(dmg);
        Destroy(gameObject);
    }
}
