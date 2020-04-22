using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMenu : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this);
    }
}
// чтобы не делать новый фон на каждой сцене, пока оставляю фон из менюхи