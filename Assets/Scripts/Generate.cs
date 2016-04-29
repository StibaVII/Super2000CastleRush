using UnityEngine;
using System.Collections;

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

    // Use this for initialization
    void Start()
    {
        
        
    }

    void Update()
    {

        float curWave = waveNumber[nextWave];
        float maxEnemy = enemyNumber[nextWave];
        if (curWave < waveNumber.Length)
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
                nextWave++;
                curEnemyNumber = 0;
                timer = 0;
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
}
