﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/*
 * Sam Ferstein
 * SpawnManager.cs
 * Assignment 6
 * This is the spawn manager.
 */

public class SpawnManager : MonoBehaviour
{
    public bool isGameActive = false;
    public GameObject enemyPrefab;
    public GameObject winScreen;
    public GameObject loseScreen;
    public GameObject startButton;
    public TextMeshProUGUI waveText;
    private float xSpawnRange = 12;
    private float ySpawnRange = 5;
    public int enemyCount;
    public int waveNumber = 1;

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if (isGameActive == true)
        {
            waveText.text = "Wave: " + waveNumber;
            if (enemyCount == 0)
            {
                waveNumber++;
                SpawnEnemyWave(waveNumber);
            }
        }
        if(waveNumber == 11)
        {
            isGameActive = false;
            waveNumber = 0;
            winScreen.gameObject.SetActive(true);
            Destroy(loseScreen.gameObject);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-xSpawnRange, xSpawnRange);
        float spawnPosY = Random.Range(-ySpawnRange, ySpawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosY);
        return randomPos;
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("TitleScreen", LoadSceneMode.Single);
    }

    public void spawn()
    {
        isGameActive = true;
        startButton.gameObject.SetActive(false);
    }
}
