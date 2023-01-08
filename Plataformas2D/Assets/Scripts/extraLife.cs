using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extraLife : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip clip;
    public GameObject item;
    public string target;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == target)
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = clip;
            audioSource.Play();
            item.SetActive(true);
            gameManager.instance.lifes_current += 1;
            Destroy(gameObject);
        }

    }

}
