using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoHorizontal : MonoBehaviour
{
    public bool punch = false;
    public float speed = 10;
    public bool isFacingRight = true;
    groundDetector_Raycast ground;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        ground = GetComponent<groundDetector_Raycast>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(horizontal * Time.deltaTime * speed, 0);
        anim.SetBool("grounded", ground.grounded);
        anim.SetBool("moving", horizontal != 0);
        

        if(isFacingRight && horizontal < 0)
        {
            Flip();
        }else if(!isFacingRight && horizontal > 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0.0f, 180.0f, 0);
    }

}
