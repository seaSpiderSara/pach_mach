using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_position_and_run : MonoBehaviour
{
    public float ballSpeed = 10f;
    public Rigidbody2D ball_;

    private Vector2 _movement;

    private void Start()
    {

    }

    private void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        ball_.MovePosition(ball_.position + _movement * ballSpeed);
    }
}
