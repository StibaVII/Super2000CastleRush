using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public Vector2 velocity = new Vector2(-5, 0);
    public GameObject target;
    public bool groundCollided = false;
    public float enemyHealth = 10f;
    public int attackTimer = 2;
    public float enemyDamage = 2f;
    float timer;
    bool castleCollided = false;
    GameObject castle;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (groundCollided)
        {
            GetComponent<Rigidbody2D>().velocity = velocity;
        }
        if (enemyHealth <= 0)
        {
            Destroy(target);
        }
        if (castleCollided)
        {
            timer += Time.deltaTime;
            if (timer > attackTimer)
            {
                castle = GameObject.FindGameObjectWithTag("Fort");
                Castle Script1 = castle.GetComponent<Castle>();
                Script1.castleHealth -= enemyDamage;
                Debug.Log("Castle health: " + Script1.castleHealth);
                timer = 0;
            }
        }
        
	}
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Ground")
        {
            groundCollided = true;
            Debug.Log("Enemy collided with Ground");
        }
        if (col.collider.tag == "Projectile")
        {
            
        }
        if (col.collider.tag == "Fort")
        {
            castleCollided = true;
            
        }
        if (col.collider.tag == "Enemy")
        {
            
        }

    }
}
