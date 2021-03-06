﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_BulletBehaviour : MonoBehaviour {

    public float yForce = 0.0f;
    public float damage = 0.0f;
    public float coolDown = 0.0f;

    private Rigidbody2D bulletRgbd2d;
    
    void Start ()
    {
        bulletRgbd2d = GetComponent<Rigidbody2D>();
        bulletRgbd2d.AddForce(new Vector2(0, yForce));
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("TopBound"))
        {
            Destroy(gameObject);
        }

        if(collision.collider.CompareTag("Enemy"))
        {
            collision.collider.GetComponent<SCR_EnemyBehaviour>().TakeDamage((int)damage);
            Destroy(gameObject);
        }
    }
}
