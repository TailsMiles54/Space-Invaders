using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Text;
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

    public void Start()
    {
        SaveShips();
    }

    void SaveShips()
    {
        string ToJSONShips = JsonUtility.ToJson(PlayerShips); 
        PlayerPrefs.SetString("PlayerShips", ToJSONShips);
        
        Debug.Log(this);
        Debug.Log(ToJSONShips);
        File.WriteAllText(@"C:\Users\Tails\Desktop\MyTest.txt", ToJSONShips); //
    }

    void LoadShips()
    {
        string FromJSONShips = PlayerPrefs.GetString("PlayerShips");
        Debug.Log(FromJSONShips);
        PlayerShips = JsonUtility.FromJson<Ships[]>(FromJSONShips);
    }

    public void Test()
    {
        SaveShips();
        LoadShips();
    }
}