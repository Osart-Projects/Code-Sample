using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    //Random value used for enemy spawaning
    public int random;

    //Wave number display
    public GameObject nextWaveText;

    //Score screen 
    public GameObject scoreScreen;

    //Defining different spawner states
    public enum SpawnState { SPAWNING, WAITING, COUNTING };

    //Enemy Transforms
    public Transform Slime;
    public Transform Warrior;
    public Transform Boss;

    //Checking if tutorial is closed
    public bool GameStarted;

    //Closing the tutorial and starting the game
    public void GameStart()
    {
        GameStarted = true;
    }

    //Wave parameters
    public int waveNumber;
    public int count;
    public float rate;
    public float timeBetweenWaves;
    public float waveCountDown;
    private float searchCountDown;

    private SpawnState state = SpawnState.COUNTING;

    void Start()
    {
        waveCountDown = timeBetweenWaves;
        searchCountDown = 1f;
    }

    void Update()
    {
        // Countdown to next wave if current ne is ompleted
        Text nextwaveText = GameObject.Find("NextWaveIn").GetComponent<Text>();
        if (waveCountDown >= 0)
        {
            nextwaveText.text = "Next Wave in: " + Mathf.FloorToInt(waveCountDown);
        }
        else
        {
            nextwaveText.text = "";
        }
 
        //Checking is any enemy alive
        if (state == SpawnState.WAITING)
        {
            if (!EnemyIsAlive())
            {
                WaveCompleted();
                return;
            }
            else
            {
                return;
            }
        }

        //Counting untill next wave
        if (waveCountDown >= 0 && GameStarted == true)
        {
            waveCountDown -= Time.deltaTime;
        }

        if (waveCountDown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {
                StartCoroutine(SpawnWave(waveNumber));
            }
        }
    }

    //Reseting wave countdown
    void WaveCompleted()
    {
        waveCountDown = timeBetweenWaves;
        state = SpawnState.COUNTING;
    }

    //Checking is any enemy alive
    bool EnemyIsAlive()
    {
        searchCountDown -= Time.deltaTime;
        if (searchCountDown <= 0f)
        {
            searchCountDown = 1f;
            if (GameObject.FindWithTag("Enemy") == null)
            {
                return false;
            }
        }
        return true;
    }

    //Spawning wave
    IEnumerator SpawnWave (int w)
    {
        waveNumber++;
        FindObjectOfType<AudioManager>().Play("WaveStart");
        Text waveName = GameObject.Find("WaveName").GetComponent<Text>();
        waveName.text = "Wave: " + waveNumber;
        rate += 0.1f;
        count += 3;

        state = SpawnState.SPAWNING;

        for (int i = 0; i < count; i++)
        {
            if (waveNumber < 3)
            {
                SpawnEnemy(Slime);
            }
            else if (waveNumber < 5)
            {
                int random = Random.Range(1, 11);
                if (random < 4)
                {
                    SpawnEnemy(Slime);
                }
                else
                {
                    SpawnEnemy(Warrior);
                }
            }
            else
            {
                int random = Random.Range(1, 11);
                if (random < 4)
                {
                    SpawnEnemy(Slime);
                }
                else if (random < 10)
                {
                    SpawnEnemy(Warrior);
                }
                else
                {
                    SpawnEnemy(Boss);
                }
            }
            yield return new WaitForSeconds(1f / rate);
        }

        state = SpawnState.WAITING;

        yield break;
    }

    //Instatiating enemy prefab
    void SpawnEnemy (Transform _enemy)
    {
        Instantiate(_enemy, new Vector3(-10, Random.Range(-0.5f, -3.5f), 0), transform.rotation);
    }

}
