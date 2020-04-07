using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float _velocity = 10;
    
    float moveSpeed = 0.2f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * moveSpeed);
        
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            transform.position = Vector3.MoveTowards(transform.position, Input.touches[0].position, Time.deltaTime * _velocity);
        }
    }
}
