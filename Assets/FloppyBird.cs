using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloppyBird : MonoBehaviour
{
    public Rigidbody2D rb;
    public AudioSource jumpSound;
    public AudioSource collisionSound;
    public Spawner spawner;
    public float jumpSpeed = 2;


    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
        
    }
    void Jump()
    {
        jumpSound.Play();
        rb.velocity = Vector2.up * jumpSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            collisionSound.Play();
        }
    }
}
