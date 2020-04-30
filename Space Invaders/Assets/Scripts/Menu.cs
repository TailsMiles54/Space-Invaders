using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject ShopMenu;

    public Text MoneyText;

    public void Start()
    {
        ShowMoney();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void OpenShop()
    {
        ShopMenu.SetActive(true);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void ExitShop()
    {
        ShopMenu.SetActive(false);
    }

    public void ShowMoney()
    {
        if (!PlayerPrefs.HasKey("PlayerMoney"))
        {
            PlayerPrefs.SetFloat("PlayerMoney",0);
        }
        float Money = PlayerPrefs.GetFloat("PlayerMoney");
        MoneyText.text = "Money: " + Money;
    }
}
