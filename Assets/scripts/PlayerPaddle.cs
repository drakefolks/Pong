using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    private void Update() //functions runs every frame, usually use to check for input
    {
        //checking for key input from user
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }

        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }

        else
        {
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate() //runs at fixed time interval, associated with physics for consistent behvaior
    {
        if (_direction.sqrMagnitude != 0) //dectects if there is movement
        {
            _rigidbody.AddForce(_direction * this.speed); //gives force
        }
    }
}
