using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

    public GameObject enemies;
    public float speed = 1f;
    public float spawnTimer = 1f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateObstacle", speed, spawnTimer);
    }

    void CreateObstacle()
    {
        Instantiate(enemies); 
    }
}
