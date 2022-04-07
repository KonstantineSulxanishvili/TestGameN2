using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentScript : MonoBehaviour
{
    private Rigidbody2D move;
    private float speed = 4;
    private float jump = 400;

    // Start is called before the first frame update
    void Start()
    {
        move = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            move.AddForce(Vector2.up * jump);
        }
        if(Input.GetKey(KeyCode.D))
        {
            move.velocity = new Vector2(speed, move.velocity.y);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            move.velocity = new Vector2(-speed, move.velocity.y);
        }
        else
        {
            move.velocity = new Vector2(0, move.velocity.y);
        }
        
    }
}
