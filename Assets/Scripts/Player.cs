using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 5;
    public Rigidbody2D rb;
    public GameObject bullet;
    public Transform muzzle;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Movement();
        Rotation();
        Attack();
	}

    void Movement()
    {
        transform.position += Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position += Vector3.up * Input.GetAxis("Vertical") * speed * Time.deltaTime;
    }

    void Rotation()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
    }

    void Attack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject newBullet = Instantiate(bullet , muzzle.position , transform.rotation);
           
        }
    }
}
