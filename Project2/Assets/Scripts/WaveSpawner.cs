using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    //spawning variables
    public Transform enemyPrefab;
    public Transform fastEnemyPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;
    private int waveNumber = 1;

    public Text waveCountdownText;
    public Text availableMoney;
    //countdown between waves
    void Update()
    {
        if(countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;
        //Update the countdown text UI
        waveCountdownText.text = Mathf.Floor(countdown).ToString();
        waveCountdownText.text = string.Format("{0:00.00}", countdown);
    }

    //spawn wave the size of the wave number
    IEnumerator SpawnWave ()
    {
        for (int i = 0; i < waveNumber*4; i++)
        {
            if(waveNumber % 3 == 0)
            {
                SpawnFastEnemy();
            }
            else
            {
                SpawnEnemy();
            }
            yield return new WaitForSeconds(0.5f);
        }
        waveNumber++;
    }
    //spawn enemies at the spawn location
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
    void SpawnFastEnemy()
    {
        Instantiate(fastEnemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
