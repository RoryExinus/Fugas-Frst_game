using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Fifth Gun")]
public class FifthGun : Gun
{
    public Transform firstFirePoint;
    public Transform secondFirePoint;
    public Transform thirdFirePoint;
    static float fireTime = 0f;

    private void OnEnable()
    {
        firstFirePoint = GameObject.FindGameObjectsWithTag("FirePoint_right")[0].transform;
        secondFirePoint = GameObject.FindGameObjectsWithTag("FirePoint_left")[0].transform;
        thirdFirePoint = GameObject.FindGameObjectsWithTag("FirePoint_middle")[0].transform;
        Player = GameObject.FindGameObjectsWithTag("Player")[0];
    }
    public override void Fire()
        
    {
        if (Time.time - fireTime >= fireRate)
        {
            fireTime = Time.time;
            Create_Bullet(firstFirePoint);
            Create_Bullet(secondFirePoint);
            Create_Bullet(thirdFirePoint);
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
