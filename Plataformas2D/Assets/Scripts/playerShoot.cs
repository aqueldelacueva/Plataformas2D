using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    Animator anim;
    public bullet bulletPrefab;
    public Transform shootOffset;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (gameManager.instance.muerte)
        {

        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                StartCoroutine(Shoot_Coroutine());
                
            }
        }
    }

    IEnumerator Shoot_Coroutine()
    {
        anim.SetBool("shoot", true);
        Instantiate(bulletPrefab, shootOffset.position, transform.rotation);
        yield return new WaitForSeconds(0.2f);
        anim.SetBool("shoot", false);
    }
}
