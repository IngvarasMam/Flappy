using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rb;
    public AudioSource audio;
    public AudioSource touched;
    public float jumpSpeed = 10;
    private void Update()
    {
        if (Input.anyKey) audio.Play();
        if (Input.anyKey) Jump();
        
    }
    void Jump()
    {
        rb.velocity = Vector2.up * jumpSpeed;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            touched.Play();
        }
    }
}
