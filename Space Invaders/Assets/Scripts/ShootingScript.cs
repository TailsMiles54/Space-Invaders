using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class ShootingScript : MonoBehaviour
{
    public float AttackSpeed = 1;

    public AudioClip piu;
    private AudioSource audio;

    public GameObject[] bullets;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        InvokeRepeating("Shot", 0, AttackSpeed); // вызов выстрела
    }

    void Shot()
    {
        audio.PlayOneShot(piu); //звук выстрела
        var asdf = Instantiate(bullets[22]);
        asdf.transform.position = gameObject.transform.position;
        asdf.AddComponent<Rigidbody>();
        asdf.AddComponent<BulletScript>();
        //тута будет спавн снаряда(у меня есть разные спрайты, будут для улучшений)
    }
}
