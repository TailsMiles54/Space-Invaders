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
        public float unlock;

        public Ships(string namec, float Costc)
        {
            name = namec;
            Cost = Costc;
            unlock = 0;
        }
    }

    public Ships[] PlayerShips;
    
    public void Awake()
    {
        
    }
}
