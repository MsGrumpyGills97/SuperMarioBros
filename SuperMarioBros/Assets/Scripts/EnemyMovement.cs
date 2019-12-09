﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //Movement variables
    private float moveSpeed = 0f; //Start idle
    
    //Controllers
    private Rigidbody2D rBody;
    private float minY;

    private void Start()
    {
        rBody = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        rBody.velocity = new Vector2(moveSpeed, rBody.velocity.y);

        //if (transform.position.y <)
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string collisionTag = collision.gameObject.tag;

        if (collisionTag != "Block" && collisionTag != "Ground" && collisionTag != "Player") //Enemy turns around when hitting collidable object that is not player or ground
        {
            moveSpeed *= -1;
        }
        else
        {
            //Player dies
        }
    }

    //Player hits trigger which starts Goomba's movement
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Collider2D boxCollider = GetComponent<Collider2D>();

        if (collision.gameObject.CompareTag("Player"))
        {
            boxCollider.enabled = false;
            
            moveSpeed = -2f;
        }
    }
}
