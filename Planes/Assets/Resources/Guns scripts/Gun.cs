using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class Gun : ScriptableObject
{

    public GameObject bulletPrefab;
    public GameObject Player;
    public float bulletforce;
    public float fireRate;

    public abstract void Fire();
    public abstract void Create_Bullet(Transform firePoint);

}
