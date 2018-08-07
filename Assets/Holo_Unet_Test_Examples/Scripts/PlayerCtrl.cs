using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerCtrl : NetworkBehaviour
{
    public float rotSpeed = 150.0f;
    public float movSpeed = 3.0f;

    private float x, z;

    // Update is called once per frame
    void Update()
    {
        if(!isLocalPlayer)
        {
            return;
        }
        PlayerMove();
    }

    void PlayerMove()
    {
        x = Input.GetAxis("Horizontal") * Time.deltaTime * rotSpeed;
        z = Input.GetAxis("Vertical") * Time.deltaTime * movSpeed;
        transform.Rotate(0,x,0);
        transform.Translate(0, 0, z);
    }
}
