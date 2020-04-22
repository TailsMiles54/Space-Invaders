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

    public Ships[] PlayerShips;

    public void Start()
    {
        SaveShips();
    }

    void SaveShips()
    {
        string ToJSONShips = JsonConvert.SerializeObject(PlayerShips);
        PlayerPrefs.SetString("PlayerShips", ToJSONShips);
        Debug.Log(ToJSONShips);
    }

    void LoadShips()
    {
        string FromJSONShips = PlayerPrefs.GetString("PlayerShips");
        Debug.Log(FromJSONShips);
        PlayerShips = JsonConvert.DeserializeObject<Ships[]>(FromJSONShips);
    }

    public void Test()
    {
        SaveShips();
        LoadShips();
    }
}
// Пытаюсь сделать хранение кулпенных игроком кораблей