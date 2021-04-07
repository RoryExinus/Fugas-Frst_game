using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUpgradeBox : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Shooting>().WeaponUpgrade();
            Destroy(gameObject);
        }
    }
}
