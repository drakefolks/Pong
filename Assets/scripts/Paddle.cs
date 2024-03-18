using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//general paddle script that will be used by both player and computer paddle
public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;

    protected Rigidbody2D _rigidbody; //protected makes it so other classes can access it, but it's not public

    private void Awake() //is only called in one life cycle of object
    {
        _rigidbody = GetComponent<Rigidbody2D>(); //getting rigid body on player paddle
    }
}
