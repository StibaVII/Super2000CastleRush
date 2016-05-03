using UnityEngine;
using System.Collections;

public class Castle : MonoBehaviour {

    public float castleHealth = 100f;
    public GameObject gameOverPanel;
    public bool dead = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (castleHealth <= 0)
        {
            dead = true;
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
            
        }
	}
}
