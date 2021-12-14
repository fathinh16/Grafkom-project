using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;

    bool facingRight;


    public int maxHealth = 100;
    public int currentHealth;
    public bool timesup; 

    public int score = 0;

    public HealthBar healthBar;
    public GameObject timer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Physics2D.IgnoreLayerCollision(8,9,true);
 
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    
        timer = GameObject.Find("TimerText");
    }

    void Update() 
    {
        FlipTrigger();
        if(currentHealth<=0) {
            gameover();
        }
        Timer timercs = timer.GetComponent<Timer>();
        timesup = timercs.Timesup();
        if(timesup == true && currentHealth>0) {
            Debug.Log("oh no! timesup!");
            levelup();
        }

    }
    private void FixedUpdate()
    {
        PlayerMovement();
    }

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

    public void TakeDamage(int damage)
    {
        Debug.Log("terumbu karang mati:(");
        currentHealth -=damage;
        healthBar.SetHealth(currentHealth);
        //Destroy(gameObject);
        //add efek mati jadi hitam
        //hapus marks
    }

    public void gameover() {
        SceneManager.LoadScene("Game Over");
    }

    public void levelup() {
        SceneManager.LoadScene("Level Completed");
    }


}
