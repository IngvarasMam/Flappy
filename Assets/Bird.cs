using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rb;
    public AudioSource audio;
    public AudioSource touched;
    public float jumpSpeed = 10;
    public TMP_Text text;
    public int score;
    private void Start()
    {
        Time.timeScale = 0;
    }
    public void BeginGame()
    {
        Time.timeScale = 1;
    }
    private void Update()
    {
        if (Input.anyKey) audio.Play();
        if (Input.anyKey) Jump();
        
    }
    void Jump()
    {
        transform.rotation = Quaternion.Euler(0,0,rb.velocity.y * 10);
        rb.velocity = Vector2.up * jumpSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        score++;
        text.text = score.ToString();
    }
}
