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

    public void BotonLevel0()
    {
        SceneManager.LoadScene("Level0");
    }

    public void BotonLevel1()
    {
        SceneManager.LoadScene("Level0");
    }

    public void BotonGimnasio()
    {
        SceneManager.LoadScene("Gimnasio");
    }

    public void BotonSalir()
    {
        Application.Quit();
    }
}