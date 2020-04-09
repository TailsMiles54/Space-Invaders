using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;

    public GameUI GameUI;
    
    private void Start()
    {
        var rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        speed = 0.1f;
        GameUI = GameObject.FindWithTag("GameUI").GetComponent<GameUI>();
    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(Vector2.down * speed,ForceMode.VelocityChange);
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
