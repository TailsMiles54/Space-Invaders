using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

public class Storage : MonoBehaviour
{
    [System.Serializable]
    public struct Ships
    {
        public string name;
        public float Cost;
        public bool unlock;
        public GameObject Prefab; 
        public Ships(string namec, float Costc, GameObject Prefabc)
        {
            name = namec;
            Cost = Costc;
            unlock = false;
            Prefab = Prefabc;
        }
    }
    public Ships[] PlayerShips;
    //буду юзать когда будет магаз, пока нахрен не нужно

    [Serializable]
    class MyClass
    {
        public List<bool> _unl; //чел посоветовал это засунуть в класс, но тогда ниже ошибки, надо попробовать обращаться через другой класс
    }

    
    public void Start()
    {
        SaveShips();
        LoadShips();
    }

    void SaveShips()
    {
        for (int i = 0; i < PlayerShips.Length; i++)
        {
            _unl.Insert(i, PlayerShips[i].unlock);
        }

        string ToJSONShips = JsonUtility.ToJson(_unl); 
        PlayerPrefs.SetString("PlayerShips", ToJSONShips);
        File.WriteAllText(@"C:\Users\Tails\Desktop\MyTest.txt", ToJSONShips); //
    }

    void LoadShips()
    {
        string FromJSONShips = PlayerPrefs.GetString("PlayerShips");
        _unl = JsonUtility.FromJson<List<bool>>(FromJSONShips);
    }
}