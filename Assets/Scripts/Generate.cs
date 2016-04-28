using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

    public GameObject enemies;
	public GameObject Canvas;
    public float speed = 1f;
    public float spawnTimer = 1f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateObstacle", speed, spawnTimer);
    }

    void CreateObstacle()
    {
        GameObject go = Instantiate(enemies, new Vector3 (0,0,0), Quaternion.identity) as GameObject; 
		go.transform.parent = GameObject.Find("Canvas").transform;
    }
}
