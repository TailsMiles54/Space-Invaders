using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]float moveSpeed = 3;

    [HideInInspector]public Vector2 targetPos;

    private void Awake()
    {
        Time.timeScale = 1;
        gameObject.transform.localScale = new Vector3(0.75f,0.75f,0.75f);
    }

    void Start()
    {
        targetPos = transform.position;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");        //для теста на ПК
        float verticalInput = Input.GetAxis("Vertical");        //для теста на ПК
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * 0.2f);     //для теста на ПК
        
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            targetPos = Camera.main.ScreenToWorldPoint(touch.position);
            transform.position = Vector2.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }
}
