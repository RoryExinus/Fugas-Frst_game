﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    //public Transform firePoint;
    //public GameObject bulletPrefab;

    //public GameObject wallPrefab;

    //public float bulletforce = 20f;
    //public float fireRate = 1f;

    //private float fireCountdown = 0f;

    public Gun gun;

    ScriptableObject[] instance = Resources.FindObjectsOfTypeAll<ScriptableObject>();
    public int WeaponUpCounter = 0;
    void Update()
    {

        if (WeaponUpCounter == 1)
        {
            gun = Resources.FindObjectsOfTypeAll<second_gun>()[0];
        }
        else if (WeaponUpCounter == 2)
        {
            gun = Resources.FindObjectsOfTypeAll<third_gun>()[0];
        }
        else if (WeaponUpCounter == 3)
        {
            gun = Resources.FindObjectsOfTypeAll<fourth_gun>()[0];
        }
        else if (WeaponUpCounter == 4)
        {
            gun = Resources.FindObjectsOfTypeAll<fifth_gun>()[0];
        }
        if (Input.GetButton("Fire1"))
        {

            gun.Fire();

        }
    }
}
