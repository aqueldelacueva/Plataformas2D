using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeController : MonoBehaviour
{
    
    public float invencible_time;
    bool invencible;
    Animator anim;
    public enum DeathMode { Teleport, ReloadScene, Destroy}
    public DeathMode death_mode;
    public Transform respawn;

    Rigidbody2D rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        gameManager.instance.lifes_current = gameManager.instance.lifes_max;
    }

    public void Damage(int damage = 1, bool ignoreInvencible = false)
    {
        if(!invencible || ignoreInvencible)
        {
            gameManager.instance.lifes_current -= damage;
            StartCoroutine(Invencible_Corutine());
            if(gameManager.instance.lifes_current <= 0)
            {
                gameManager.instance.fire--;
                Death();
            }
        }
    }

    public void Death()
    {
        Debug.Log("He Muerto");
        switch (death_mode)
        {
            case DeathMode.Teleport:
                rb.velocity = new Vector2(0, 0);
                transform.position = respawn.position;
                gameManager.instance.lifes_current = gameManager.instance.lifes_max;
                break;
            case DeathMode.ReloadScene:

                break;
            case DeathMode.Destroy:
                Destroy(gameObject);
                break;
            default:
                break;
        }
    }

    IEnumerator Invencible_Corutine()
    {
        invencible = true;
        anim.SetBool("Damage", true);
        yield return new WaitForSeconds(invencible_time);
        invencible = false;
        anim.SetBool("Damage", false);
    }
}
