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
        GameUI = GameObject.FindWithTag("GameUI").GetComponent<GameUI>(); // надо убрать будет поиск и сделать иначе, или хотя бы не спавнить врагов а выдергивать из пула
        
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
        if (other.gameObject.tag != "Enemy")
        {
            if (other.gameObject.tag == "Bullet")
            {
                UdarBullet(other.gameObject);
            }
            if (other.gameObject.tag == "Player")
            {
                UdarPlayer(other.gameObject);
            }
        }
    }

    void UdarBullet(GameObject other)
    {
        GameUI.Score += 1;
        GameUI.UIUpdate();
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
    void UdarPlayer(GameObject other)
    {
        if (GameUI.Health > 0)
        {
            GameUI.Health -= 1;
            Destroy(gameObject);
            GameUI.UIUpdate();
        }

        if (GameUI.Health <= 0)
        {
            Destroy(other);
            GameUI.Lose();
            GameUI.UIUpdate();
        }
    }
}
// движение противинка + столкновение с игроком и пулей