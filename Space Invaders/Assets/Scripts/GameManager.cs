using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector3 Startpos;
    [HideInInspector]public GameObject PlayerShip;

    public void Start()
    {
        GameObject Player = Instantiate(PlayerShip);
        Player.transform.position = Startpos;
        Player.AddComponent<PlayerMovement>();
    }
}
// будет нужно когда доделаю магаз