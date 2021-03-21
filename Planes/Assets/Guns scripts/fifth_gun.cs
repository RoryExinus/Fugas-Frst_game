using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "fifth_Gun")]
public class fifth_gun : Gun
{
    public Transform first_firePoint;
    public Transform second_firePoint;
    public Transform third_firePoint;
    static float fireTime = 0f;

    private void OnEnable()
    {
        first_firePoint = GameObject.FindGameObjectsWithTag("FirePoint_right")[0].transform;
        second_firePoint = GameObject.FindGameObjectsWithTag("FirePoint_left")[0].transform;
        third_firePoint = GameObject.FindGameObjectsWithTag("FirePoint_middle")[0].transform;
        Player = GameObject.FindGameObjectsWithTag("Player")[0];
    }
    public override void Fire()
    {
        if (Time.time - fireTime >= fireRate)
        {
            fireTime = Time.time;
            Create_Bullet(first_firePoint);
            Create_Bullet(second_firePoint);
            Create_Bullet(third_firePoint);
        }
    }
    public override void Create_Bullet(Transform i_firePoint)
    {
        GameObject bullet = Instantiate(bulletPrefab, i_firePoint.position, i_firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), Player.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), bullet.GetComponent<Collider2D>());

        rb.AddForce(i_firePoint.up * bulletforce, ForceMode2D.Impulse);
    }

}
