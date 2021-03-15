using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundLoop : MonoBehaviour
{
    public float speed = 0.1f;
    private Vector2 offset = Vector2.zero;
    private Material material;
    void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = material.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        offset.y += speed + Time.deltaTime / 100;
        material.SetTextureOffset("_MainTex", offset);
    }
}
