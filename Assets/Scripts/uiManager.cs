using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour
{
    public TextMeshProUGUI vidas;
    public TextMeshProUGUI fires;
    public GameObject gameOver;
    public GameObject Player;
    public int vida;
    public int fire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.instance.fire < 0)
        {
            gameOver.SetActive(true);
            Destroy(Player);
            StartCoroutine(Muerte_Coroutine());
        }
        vida = gameManager.instance.lifes_current;
        vidas.text = vida.ToString();
        fire = gameManager.instance.fire;
        fires.text = fire.ToString();

    }
    IEnumerator Muerte_Coroutine()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Menu");
    }
}
