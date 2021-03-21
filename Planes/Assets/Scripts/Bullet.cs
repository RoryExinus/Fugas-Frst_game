using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float dmg;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        AsteroidScript aster = collision.GetComponent<AsteroidScript>();
        aster.TakeDamage(dmg);
        Destroy(gameObject);
    }
}
