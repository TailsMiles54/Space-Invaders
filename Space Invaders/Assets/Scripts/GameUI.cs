using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text UILevel;
    public Text UIHealth;
    public Text UIScore;

    [HideInInspector] public float Level = 1;
    [HideInInspector] public float Health = 5;
    [HideInInspector] public float Score = 1;

    private void FixedUpdate()
    {
        UIUpdate();
    }

    public void UIUpdate()
    {
        UILevel.text = "Level: " + Level;
        UIHealth.text = "Health: " + Health;
        UIScore.text = "Score: " + Score;
    }

    public void KillEnemy()
    {
        
    }
}
