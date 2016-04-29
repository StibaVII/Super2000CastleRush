using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public Vector2 velocity = new Vector2(-5, 0);
    public GameObject target;
    public bool groundCollided = false;
    public float enemyHealth = 10f;

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

    }
}
