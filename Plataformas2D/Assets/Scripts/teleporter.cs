using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip teleport;
    Rigidbody2D rb;
    public bool active = true;
    public float inactive_time = 2;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameManager.instance.totem && collision.tag == tp.instance.target && active)
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = teleport;
            audioSource.Play();
            rb.velocity = new Vector2(0, 0);
            transform.position = tp.instance.teleport_point.position;
            StartCoroutine(Active_Corutine());
        }

    }
    IEnumerator Active_Corutine()
    {
        active = false;
        yield return new WaitForSeconds(inactive_time);
        active = true;
    }
}
