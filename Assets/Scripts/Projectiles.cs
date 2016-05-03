﻿using UnityEngine;
using System.Collections;

public class Projectiles : MonoBehaviour {

    public GameObject arrow;
    public Vector2 velocity = new Vector2(5, 0);
    public Canvas canvas;
    public float scalex = 15f;
    public float scaley = 3f;
	public float amount = 2000000f;
    public GameObject hero;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            CreateArrow();
        }
	}

    void CreateArrow()
    {
        GameObject arrowsSpawned = Instantiate(arrow);
        arrowsSpawned.transform.SetParent(canvas.transform);
        arrowsSpawned.GetComponent<Rigidbody2D>().velocity = velocity;
		        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
				Vector3 dir = (Input.mousePosition - sp).normalized;
        Vector3 spawnScale = new Vector3(scalex, scaley);
        Vector3 spawnPosition = new Vector3(hero.transform.localPosition.x, hero.transform.localPosition.y);
        arrowsSpawned.transform.localScale = spawnScale;
        arrowsSpawned.transform.localPosition = spawnPosition;
		arrowsSpawned.GetComponent<Rigidbody2D>().AddForce (dir * amount);
    }
}
