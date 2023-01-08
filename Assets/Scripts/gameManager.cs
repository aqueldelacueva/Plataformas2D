using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public static gameManager instance;
    public int lifes_current;
    public int lifes_max;
    public bool totem = false;
    public bool muerte;
    public int fire;

    private void Awake()
    {
        instance = this; 
    }

    void Update()
    {
        
    }
}
