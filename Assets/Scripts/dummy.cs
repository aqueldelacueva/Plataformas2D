using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class dummy : MonoBehaviour
{

    public int damage;
    public bool ignoreInvencible;
    public string target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == target)
        {
            Destroy(gameObject);
        }

    }
}
