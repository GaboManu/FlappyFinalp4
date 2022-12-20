using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReapitingBackround : MonoBehaviour
{

    private BoxCollider2D groundCollider;
    private float groundHorizontalLength;

    private void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x;
    }

    private void Update()
    {
        if (transform.position.x < -groundHorizontalLength)
        {
            RepositionBackround();
        }
    }


    private void RepositionBackround()
    {
        Vector2 groundoffSet = new Vector2(groundHorizontalLength * 2f, 0);
        transform.position = (Vector2)transform.position + groundoffSet;
    }
}
