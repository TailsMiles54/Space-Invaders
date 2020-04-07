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

    [HideInInspector] public float Level;
    [HideInInspector] public float Health;
    [HideInInspector] public float Score;

    void Awake()
    {
        UIUpdate();
    }

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
}
