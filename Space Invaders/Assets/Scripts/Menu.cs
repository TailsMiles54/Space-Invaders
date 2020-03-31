using System;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using System.IO;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject ShopMenu;
    void Awake()
    {
       
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
}
