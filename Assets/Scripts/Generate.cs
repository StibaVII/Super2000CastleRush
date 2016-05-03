using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Generate : MonoBehaviour {

    public GameObject enemies;
	public GameObject enemySpawn;
    public float scalex = 33f;
    public float scaley = 33f;
    public float speed = 1f;
    float timer;
    public int spawnTimer = 3;
    public float[] waveNumber;
    public float[] enemyNumber;
    public Canvas canvas;
    public float curEnemyNumber = 0f;
    public int nextWave = 0;
	float waveTimer;
    public int waitNextWave = 10;
    GameObject castle;
    public GameObject waitingPanel;
    public Text waitingNumber;
    public GameObject winPanel;

    // Use this for initialization
    void Start()
    {
        
        
    }

    void Update()
    {
        castle = GameObject.FindGameObjectWithTag("Fort");
        Castle Script1 = castle.GetComponent<Castle>();
        if (Script1.dead == false)
        {
            float curWave = waveNumber[nextWave];
            float maxEnemy = enemyNumber[nextWave];
            if (curWave <= waveNumber.Length)
            {
                timer += Time.deltaTime;
                if (curEnemyNumber < maxEnemy && timer > spawnTimer)
                {
                    CreateObstacle();
                    curEnemyNumber++;
                    Debug.Log(curEnemyNumber);
                    timer = 0;
                }
                if (curEnemyNumber == maxEnemy && GameObject.FindGameObjectWithTag("Enemy") == null)
                {
                    waitingPanel.SetActive(true);
                    float roundedTime = waitNextWave - waveTimer;
                    roundedTime = Mathf.Round(roundedTime);
                    waitingNumber.text = roundedTime.ToString();
                    waveTimer += Time.deltaTime;
                    if (waveTimer > waitNextWave && curWave <= waveNumber.Length)
                    {
                        waitingPanel.SetActive(false);
                        nextWave++;
                        curEnemyNumber = 0;
                        timer = 0;
                        waveTimer = 0;
                    }   
                }
            }
        }
    }

    void CreateObstacle()
    {
        GameObject enemiesSpawned = Instantiate(enemies);
        Vector3 spawnPosition = new Vector3(enemySpawn.transform.localPosition.x, enemySpawn.transform.localPosition.y);
        Vector3 spawnScale = new Vector3(scalex, scaley);
        enemiesSpawned.transform.SetParent(canvas.transform);
        enemiesSpawned.transform.localPosition = spawnPosition;
        enemiesSpawned.transform.localScale = spawnScale;
    }

    public void SkipWait()
    {
        waveTimer = 10000;
    }
}
