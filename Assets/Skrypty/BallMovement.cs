using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private ScoreManager scoreManager;
    private float fX, fY;
    void InitiateBallMovement()
    {
        rb2d.velocity = new Vector2(fX, fY);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = rb2d.velocity.x;
            if (vel.x < 20f)
            {
                vel.y = (rb2d.velocity.y / 2) + (collision.collider.attachedRigidbody.velocity.y / 3);
            }
            else
            {
                vel.y = rb2d.velocity.y;
            }
            //vel.y = (rb2d.velocity.y/2) + (collision.collider.attachedRigidbody.velocity.y / 3);
            rb2d.velocity = vel;
        }
    } //obsluga odbic paletki

    private void OnTriggerEnter2D(Collider2D trigger) //obsluga triggerow
    {
        scoreManager.IncreasePlayerScore(trigger.name);
        ResetBall();
        fY = Random.Range(-2, 2);
        float random = Random.Range(0, 2);
        if (random < 1)
        {
            fX *= (-1);
        }
        InitiateBallMovement();
    }
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        rb2d = GetComponent<Rigidbody2D>();
        fX = 6.5f;
        fY = Random.Range(-2,2);
        float random = Random.Range(0, 2);
        if (random < 1)
        {
            fX *= (-1);
        }
        InitiateBallMovement();
    }
    void ResetBall()
    {
        transform.position = new Vector2(0, 0);
    }
}
