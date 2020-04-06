using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletspeed = 1f;
    private Vector3 start,end;
    private void Start()
    {
        var rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        start = gameObject.transform.position;
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(Vector2.up * bulletspeed,ForceMode.VelocityChange);
        end = gameObject.transform.position;
    }
    
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
