using UnityEngine;
using System.Collections;

public class UVScroll : MonoBehaviour
{
    //public Vector2 speed;

    //void LateUpdate()
    //{
    //    GetComponent<Renderer>().material.mainTextureOffset = speed * Time.time;
    //}
    void Start()
    {
        var height = Camera.main.orthographicSize * 2f;
        var width = height * Screen.width / Screen.height;

        if (gameObject.name == "TestBackground")
        {
            transform.localScale = new Vector3(width, height, 0);
        }
    }
}