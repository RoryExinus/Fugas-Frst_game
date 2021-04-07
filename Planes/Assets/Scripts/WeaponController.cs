using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    public GameObject bullet;
    public Transform firePoint;
    public float deley;
    public float fireRate;


    public GameObject playerExplodeEffect;



    private GameController gm;

    void Start()
    {
        InvokeRepeating("Fire", deley, fireRate);
    }

    void Fire()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }

}
