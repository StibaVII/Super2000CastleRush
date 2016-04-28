using UnityEngine;
using System.Collections;

public class MoveEnemies : MonoBehaviour {
public GameObject enemies;
public Vector3 scale;
	// Use this for initialization
	void Start () {
			enemies.transform.localScale = (scale);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
