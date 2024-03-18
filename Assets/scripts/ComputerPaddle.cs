using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball; //making public so I can assign the ball object to this rigidbody in unity
    private void FixedUpdate()
    {
        if (this.ball.velocity.x > 0.0f) //if the ball is moving right, which is towards computer paddle
        {
            if (this.ball.position.y > this.transform.position.y) //if the ball is above computer paddle, move computer paddle up
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
            else if (this.ball.position.y < this.transform.position.y) //if the ball is below, move down
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }

        else 
        {
            if (this.transform.position.y > 0.0f) //if current position is above center, move down
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }

            else if(this.transform.position.y < 0.0f)
            {
                _rigidbody.AddForce(Vector2.up * this.speed); //if current position is below center, move up
            }
        }
    }
}
