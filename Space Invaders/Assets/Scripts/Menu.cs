using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject ShopMenu;
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
}
