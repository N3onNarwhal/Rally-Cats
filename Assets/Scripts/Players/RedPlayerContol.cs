using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayerContol : MonoBehaviour
{
    public KeyCode moveLeft = KeyCode.LeftArrow;
    public KeyCode moveRight = KeyCode.RightArrow;
    public float speed = 5.0f;
    public float boundX = 2.5f;
    public Rigidbody2D body;
    public bool facingLeft;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        facingLeft = false;
    }

    void Update()
    {
        var velocity = body.velocity;
        if (Input.GetKey(moveRight)){
            velocity.x = speed;
            if (facingLeft){
                Flip();
            }
        }
        else if (Input.GetKey(moveLeft)){
            velocity.x = -speed;
            if (!facingLeft){
                Flip();
            }
        }
        else {
            velocity.x = 0.0f;
        }
        body.velocity = velocity;

        var pos = transform.position;
        if (pos.x > boundX){
            pos.x = boundX;
        }
        else if (pos.x < -boundX){
            pos.x = -boundX;
        }

        if (pos.y != 3.5f){
            pos.y = 3.5f;
        }

        transform.position = pos;
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingLeft = !facingLeft;
    }
}
