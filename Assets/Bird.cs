using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rb;
    public AudioSource audio;
    public AudioSource touched;
    private void Update()
    {
        if (Input.anyKey) audio.Play();
        if (Input.anyKey) Jump();
        
    }
    void Jump()
    {
        rb.velocity = new Vector2(0, 5);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            touched.Play();
        }
    }
}
