using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class enemy : MonoBehaviour
{
    private float dirx;
    private float speed;
    private Rigidbody2D rb;
    private bool isFacingRight = false;
    private Vector3 localScale;
    void Start()
    {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        dirx = -1f;
        speed = 3f;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Point>())
        {
            dirx *= -1f;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirx * speed, rb.velocity.y);
    }

    private void LateUpdate()
    {
        CheckWhereToFace();
    }
    void CheckWhereToFace()
    {
        if(dirx > 0)
        {
            isFacingRight= true;
        }else if (dirx < 0){
            isFacingRight= false;
        }
        if(((isFacingRight) && (localScale.x < 0)) || ((!isFacingRight) && (localScale.x > 0)))
        {
            localScale.x *= -1;

            transform.localScale = localScale;
        }
    }
}