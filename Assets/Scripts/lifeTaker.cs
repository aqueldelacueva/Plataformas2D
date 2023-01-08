using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeTaker : MonoBehaviour
{
    public int damage;
    public bool ignoreInvencible;
    public string target;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == target)
        {
            collision.GetComponent<lifeController>().Damage(damage, ignoreInvencible);
        }

    }
}
