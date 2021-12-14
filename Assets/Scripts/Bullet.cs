using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 0f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up *2;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Patrol kapal = hitInfo.GetComponent<Patrol>();
        if(kapal !=null) {
            kapal.Death();
//            Destroy(gameObject);
        }        
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }

}
