using UnityEngine;
using System.Collections;

public class Projectiles : MonoBehaviour {

    public GameObject arrow;
    public Vector2 velocity = new Vector2(5, 0);
    public Canvas canvas;
    public float scalex = 15f;
    public float scaley = 3f;
    public GameObject hero;
    GameObject castle;
                   
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        castle = GameObject.FindGameObjectWithTag("Fort");
        Castle Script1 = castle.GetComponent<Castle>();
        if (Script1.dead == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                CreateArrow();
            }
        }
        
	}

    void CreateArrow()
    {
        GameObject arrowsSpawned = Instantiate(arrow);
        arrowsSpawned.transform.SetParent(canvas.transform);
        arrowsSpawned.GetComponent<Rigidbody2D>().velocity = velocity;
        Vector3 spawnScale = new Vector3(scalex, scaley);
        Vector3 spawnPosition = new Vector3(hero.transform.localPosition.x, hero.transform.localPosition.y);
        arrowsSpawned.transform.localScale = spawnScale;
        arrowsSpawned.transform.localPosition = spawnPosition;
    }
}
