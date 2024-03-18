using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 200.0f;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start() //will only be called once
    {
        AddStartingForce();
    }

    private void AddStartingForce() //creating random first movement for ball
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f; //if less than half go one way, if greater go another way. 
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this.speed);
    }
}
