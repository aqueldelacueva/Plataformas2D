using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extraLife : MonoBehaviour
{
    public GameObject item;
    public string target;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == target)
        {
            item.SetActive(true);
            gameManager.instance.lifes_current += 1;
            Destroy(gameObject);
        }

    }

}
