using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : NetworkBehaviour 
{
    void HandleMovement()
    {
            float moveh = Input.GetAxis("Horizontal");
            float movev = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveh, movev,0);
            transform.position = transform.position + movement;        
    }

    void Update()
    {
        HandleMovement();
    }
}
