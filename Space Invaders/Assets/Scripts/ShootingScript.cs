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

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        InvokeRepeating("Shot", 0, AttackSpeed); // вызов выстрела
    }

    void Shot()
    {
        audio.PlayOneShot(piu);
        //тута будет спавн снаряда(у меня есть разные спрайты, будут для улучшений)
        //дальше надо сюда же звук выстрела запихать
    }
}
