using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penembak : MonoBehaviour
{
    public float speed = 0f;
    public int points = 10;
    public Rigidbody2D rb;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up *200;
        player = GameObject.Find("Dewa Laut");
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        if(hitInfo.GetComponent<Bombs>() !=null) {
            Score.instance.AddPoint();
            Destroy(gameObject);
            //Dewascript pscript = player.GetComponent<Dewascript>();
            //pscript.addScore(points);
        }
        if(hitInfo.gameObject.CompareTag("Batasatas")) {
        Destroy(gameObject);

        }
    }
}
