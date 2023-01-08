using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class totem : MonoBehaviour
{
    public GameObject item;
    public string target;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == target)
        {
            item.SetActive(true);
            gameManager.instance.totem = true;
            Destroy(gameObject);
        }

    }
}
