using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]
public class Gun : ScriptableObject
{
    public Transform first_firePoint;
    public Transform second_SecondPoint;
    public Transform third_FirePoint;
    public GameObject bulletPrefab;
    public float dmg;
    public float bulletforce;
    public float fireRate;

    public virtual void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, first_firePoint.position, first_firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(first_firePoint.up * bulletforce, ForceMode2D.Impulse);
    }
}
