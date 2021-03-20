using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;

    public GameObject wallPrefab;

    public float bulletforce = 20f;
    public float fireRate = 1f;

    private float fireCountdown = 0f;
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= fireCountdown)
        {
            fireCountdown = Time.time + 1f / fireRate;
            Shoot();

        }
    }

    void Shoot() 
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), wallPrefab.GetComponent<Collider2D>());
        rb.AddForce(firePoint.up * bulletforce, ForceMode2D.Impulse);
    }
}
