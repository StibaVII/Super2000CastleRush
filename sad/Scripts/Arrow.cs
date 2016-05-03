using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {
    public GameObject target;
    public float damage;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Ground")
        {
            Destroy(target);
        }
        if (col.collider.tag == "Enemy")
        {
            Transform collidedWith = col.collider.GetComponent<Transform>();
            Enemy Script1 = collidedWith.GetComponent<Enemy>();
            Script1.enemyHealth -= damage;
            Debug.Log("Enemy health: " + Script1.enemyHealth);
            Destroy(target);
        }

    }
}
