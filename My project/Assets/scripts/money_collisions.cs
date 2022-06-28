using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money_collisions : MonoBehaviour
{
    public GameObject ball_d;
   // public Rigidbody2d newBall;

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "ballll")
        {
            //update cash
            moneyManage.instance.AddPoint();
            //Destroy(ball_d);
            ball_position_and_run.instance.OneMoreTry();


        }
    }
}
