using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

/*
 * Sam Ferstein
 * GameManager.cs
 * Assignment 6
 * This is the game manager.
 */

public class GameManager : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject gOverScreen;
    public GameObject gWinScreen;
    public GameObject startButton;
    public TextMeshProUGUI waveText;
    public TextMeshProUGUI healthText;
    public GameObject player;
    public bool isGameActive;
    public bool isGameLost = false;


    // Start is called before the first frame update
    void Start()
    {
        waveText.gameObject.SetActive(false);
        healthText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        isGameActive = true;
        isGameLost = false;
        player.gameObject.SetActive(true);
        titleScreen.gameObject.SetActive(false);
        startButton.gameObject.SetActive(true);
        waveText.gameObject.SetActive(true);
        healthText.gameObject.SetActive(true);
    }

    public void gameOver()
    {
        isGameLost = true;
        gOverScreen.gameObject.SetActive(true);
        waveText.gameObject.SetActive(false);
        healthText.gameObject.SetActive(false);
        isGameActive = false;
    }

    public void gameWon()
    {
        player.gameObject.SetActive(false);
        gWinScreen.gameObject.SetActive(true);
        waveText.gameObject.SetActive(false);
        healthText.gameObject.SetActive(false);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
