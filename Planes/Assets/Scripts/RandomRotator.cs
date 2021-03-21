using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    public float tumble;
    public Rigidbody2D rb;
    
    public void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        rb.angularVelocity = Random.insideUnitCircle.x * tumble;
    }
}
