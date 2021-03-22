using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Gun gun;

    private Gun first_weapon;
    private Gun second_weapon;
    private Gun third_weapon;
    private Gun fourth_weapon;
    private Gun fifth_weapon;

    public int WeaponUpCounter = 0;
    void Start()
    {
        first_weapon = Resources.LoadAll<Gun>("Gun's Instantces/Start Gun")[0];
        second_weapon = Resources.LoadAll<Gun>("Gun's Instantces/Second Gun")[0];
        third_weapon = Resources.LoadAll<Gun>("Gun's Instantces/Third Gun")[0];
        fourth_weapon = Resources.LoadAll<Gun>("Gun's Instantces/Fourth Gun")[0];
        fifth_weapon = Resources.LoadAll<Gun>("Gun's Instantces/Fifth Gun")[0];
    }
    void Update()
    {
        if (WeaponUpCounter == 0)
        {
            gun = Instantiate(first_weapon);
        }
        else if (WeaponUpCounter == 1)
        {
            gun = Instantiate(second_weapon);
        }
        else if (WeaponUpCounter == 2)
        {
            gun = Instantiate(third_weapon);
        }
        else if (WeaponUpCounter == 3)
        {
            gun = Instantiate(fourth_weapon);
        }
        else
        {
            gun = Instantiate(fifth_weapon);
        }
        if (Input.GetButton("Fire1"))
        {

            gun.Fire();

        }
    }

    public void WeaponUpgrade()
    {
        WeaponUpCounter++;
    }
}
