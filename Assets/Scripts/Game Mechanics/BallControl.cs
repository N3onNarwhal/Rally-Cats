using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D body;
    GameObject ball;
    public ScoreManager scoreManager;
    public GameObject hitSFX;
    public bool BlueStart = true;
    
    void GoBall()
    {
        if (BlueStart){
            float rand = Random.Range(0, 1);
            if(rand < 0.5f){
                body.AddForce(new Vector2(5, -35));
            } 
            else if (rand < 1.0f){
                body.AddForce(new Vector2(-5, -35));
            }
        }
        else if (!BlueStart) {
            float rand = Random.Range(0, 1);
            if(rand < 0.5f){
                body.AddForce(new Vector2(5, 35));
            } 
            else if (rand < 1.0f){
                body.AddForce(new Vector2(-5, 35));
            }
        }
    }

    void Start () 
    {
        body = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }

    void ResetBall()
    {
        body.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        Invoke("GoBall", 1);
    }

    void RestartGame()
    {
        ResetBall();
    }

    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.y = body.velocity.y;
            if (body.velocity.x > 5.0f){
                vel.x = 5.0f;
            }
            else {
                vel.x = body.velocity.x + 1.5f;
            }
            body.velocity = vel;
            Instantiate(hitSFX, transform.position, transform.rotation);
        }
        else if(coll.gameObject.name == "TopWall")
        {
            scoreManager.BlueScore();
            BlueStart = false;
            ResetBall();
        }
        else if (coll.gameObject.name == "BottomWall")
        {
            scoreManager.RedScore();
            BlueStart = true;
            ResetBall();
        }
    }
}
