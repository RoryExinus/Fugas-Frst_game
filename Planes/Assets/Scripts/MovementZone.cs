using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementZone : MonoBehaviour
{
    public SpriteRenderer sprRnd;
    public Camera cam;

    void Update()
    {
        //Using world space calculations
        //Get limits using viewport positions
        Vector3 leftBottom = cam.ViewportToWorldPoint(Vector3.zero);
        Vector3 rightTop = cam.ViewportToWorldPoint(new Vector3(1, 1, 0));
        float leftLimit = leftBottom.x;
        float botLimit = leftBottom.y;
        float rightLimit = rightTop.x;
        float topLimit = rightTop.y;
        Vector3 extents = sprRnd.bounds.extents;
        //Clamp with sprite extends offset added
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, leftLimit + extents.x, rightLimit - extents.x);
        pos.y = Mathf.Clamp(pos.y, botLimit + extents.y, topLimit - extents.y);
        transform.position = pos;
     }
}
