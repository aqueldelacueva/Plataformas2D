using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class bullet : MonoBehaviour
{
    public float speed = 4.5f;
    public float bulletDestroy;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right* speed;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, bulletDestroy);
    }

}
