using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuInGame : MonoBehaviour
{
    public GameObject menu;
    bool esc_press = false;

    
    void Update()
    {
        if (esc_press == false && Input.GetKeyDown(KeyCode.Escape))
        {
            menu.SetActive(true);
            Time.timeScale = 0;
            esc_press = true;
        }
        else if (esc_press == true && Input.GetKeyDown(KeyCode.Escape))
        {
            menu.SetActive(false);
            Time.timeScale = 1;
            esc_press = false;
        }
    }

    public void Boton_continuar()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
        esc_press = false;
    }

    public void Boton_menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
