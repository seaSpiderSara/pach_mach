using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_position_and_run : MonoBehaviour
{ 
    public static ball_position_and_run instance;
    
    public float ballSpeed = 10f;
    public Rigidbody2D ball_;
    public bool controller = true;
    private Vector2 _movement;

    public KeyCode run_ = KeyCode.Space;

    private void Awake()
    {
        instance = this;
    }

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

    public void OneMoreTry()
    {
        transform.position = new Vector3(1.79f, 3.09f, 0);
        ball_.gravityScale = 0;
        controller = true;
    }
    
}
