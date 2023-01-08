using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp : MonoBehaviour
{
    public static tp instance;
    public Transform teleport_point;
    public string target;

    private void Awake()
    {
        instance = this;
    }
    
}
