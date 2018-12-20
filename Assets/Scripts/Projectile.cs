using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public BoxCollider2D bc;
    public Rigidbody2D rb;
    public float speed;
	// Use this for initialization
	void Awake () {

    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed * Time.fixedDeltaTime;

    }
    // Update is called once per frame
    void Update () {
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    void Impact()
    {

    }
}
