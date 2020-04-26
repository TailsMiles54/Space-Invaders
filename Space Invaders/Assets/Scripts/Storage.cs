using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;

public class Storage : MonoBehaviour
{
    [Serializable]
    public struct ShopShips
    {
        public string ShopShipsName;
        public float ShopShipsCost;
        public bool ShopShipsUnlock;
        public GameObject ShopShipsPrefab;
    }
    
    [Serializable]
    public struct Ships
    {
        public string name;
        public float Cost;
        public bool unlock; 
        public Ships(string namec, float Costc)
        {
            name = namec;
            Cost = Costc;
            unlock = false;
        }
    }

    public ShopShips[] ShopShipsStorage; 
    public Ships[] PlayerShips;

    public void Start()
    {
        if (PlayerPrefs.HasKey("PlayerShips"))
        {
            LoadShips();
        }
        else
        {
            SaveShips();
        }
    }

    void SaveShips()
    {
        for (int i = 0; i < PlayerShips.Length; i++)
        {
            PlayerShips[i].name = ShopShipsStorage[i].ShopShipsName;
            PlayerShips[i].Cost = ShopShipsStorage[i].ShopShipsCost;
            PlayerShips[i].unlock = ShopShipsStorage[i].ShopShipsUnlock;
        }
        
        string ToJSONShips = JsonConvert.SerializeObject(PlayerShips);
        PlayerPrefs.SetString("PlayerShips", ToJSONShips);
        Debug.Log(ToJSONShips);
    }

    void LoadShips()
    {
        string FromJSONShips = PlayerPrefs.GetString("PlayerShips");
        PlayerShips = JsonConvert.DeserializeObject<Ships[]>(FromJSONShips);
        
        for (int i = 0; i < PlayerShips.Length; i++)
        {
           ShopShipsStorage[i].ShopShipsName =  PlayerShips[i].name;
           ShopShipsStorage[i].ShopShipsCost =  PlayerShips[i].Cost;
           ShopShipsStorage[i].ShopShipsUnlock =  PlayerShips[i].unlock;
        }
    }

    public void SaveStorage()
    {
        SaveShips();
    }
}
// Пытаюсь сделать хранение кулпенных игроком кораблей