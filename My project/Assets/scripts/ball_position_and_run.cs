using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_position_and_run : MonoBehaviour
{
    public float ballSpeed = 10f;
    public Rigidbody2D ball_;
    public bool controller = true;
    private Vector2 _movement;

    public KeyCode run_ = KeyCode.Space;
   // public GameObject ball_game;

    private void Start()
    {

    }

    private void Update()
    {
        if(controller == true)
        {
            _movement.x = Input.GetAxisRaw("Horizontal");
        }
        

        if (Input.GetKeyDown(run_))
        {
            controller = false;
            ball_.gravityScale = 35;

        }
    }

    private void FixedUpdate()
    {
        ball_.MovePosition(ball_.position + _movement * ballSpeed);
    }
}
