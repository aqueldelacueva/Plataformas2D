using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody2D rb;
    public float force = 500;
    public int jumps;
    public int max_jumps = 2;
    groundDetector_Raycast ground;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ground = GetComponent<groundDetector_Raycast>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ground.grounded)
        {
            jumps = max_jumps;
        }

        if (Input.GetButtonDown("Jump") && jumps > 0) //con && ground.grounded para que si esta en el suelo no salte
        {
            rb.AddForce(new Vector2(0, force));
            jumps = jumps - 1;
        }
    }

    
}
