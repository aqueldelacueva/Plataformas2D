using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public void BotonEmpezar()
    {
        SceneManager.LoadScene("Level0");
    }

    public void BotonSalir()
    {
        Application.Quit();
    }
}