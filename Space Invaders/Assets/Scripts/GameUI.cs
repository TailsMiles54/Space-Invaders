using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text UILevel;
    public Text UIHealth;
    public Text UIScore;
    public Text LoseScore;

    public GameObject LosePanel,PausePanel;

    public float Level = 1;
    public float Health = 5;
    public float Score = 1;

    public void UIUpdate()
    {
        UILevel.text = "Level: " + Level;
        UIHealth.text = "Health: " + Health;
        UIScore.text = "Score: " + Score;
    }

    public void Back()
    {
        SaveMoney();
        SceneManager.LoadScene("Menu");
    }

    public void Lose()
    {
        Time.timeScale = 0;
        LoseScore.text = "Score: " + Score;
        LosePanel.SetActive(true);
    }

    public void PausePanelActive()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
    }

    public void PausePanelDeactive()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }

    public void SaveMoney()
    {
        float LoadScore = PlayerPrefs.GetFloat("PlayerMoney");
        PlayerPrefs.SetFloat("PlayerMoney",LoadScore + Score);
        PlayerPrefs.Save();
    }
}

// UI в игре