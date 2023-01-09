using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lapida : MonoBehaviour
{
    // Start is called before the first frame update
    public string target;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == target)
        {
            gameManager.instance.fire = -1;
            gameManager.instance.lifes_current = 0;
        }

    }
}
