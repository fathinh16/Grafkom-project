using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dewascript : MonoBehaviour
{
    public Score Score;
    public float speed;
    Rigidbody2D rb;

    bool facingRight;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    //public int playerScore = 0;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

 
    }

    void Update() 
    {
        FlipTrigger();
        if(currentHealth<=0) {
            gameover();
        }

    }
    private void FixedUpdate()
    {
        PlayerMovement();
    }
    public void TakeDamage(int damage)
    {
        Debug.Log("terumbu karang mati:(");
        currentHealth -=damage;
        healthBar.SetHealth(currentHealth);
        //Destroy(gameObject);
        //add efek mati jadi hitam
        //hapus marks
    }

    //public void addScore(int points) {
    //    playerScore +=points;
    //}

    //public int Score() {
      //  return playerScore;
    //}

    void PlayerMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x*speed, y*speed, 0f);
        rb.velocity = movement;
    }

    void FlipTrigger() 
    {
        if(rb.velocity.x >0 && facingRight) 
        {
            FlipPlayer();
        }
        else if(rb.velocity.x <0 && !facingRight)
        {
            FlipPlayer();
        }
    }
    void FlipPlayer() 
    {
        facingRight = !facingRight;

        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }

    public void gameover() {
        Score.Setup();
    }

}
