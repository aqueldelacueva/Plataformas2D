using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    public string level;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(level);
    }
}
