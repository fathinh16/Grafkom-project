using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombs : MonoBehaviour
{
    public float speed = 0f;

    public int damage1 = 20;
    public Rigidbody2D rb;

    public AudioClip Sound;
    public AudioSource bombsound;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = -transform.up *200;
        bombsound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Terumbu terumbu = hitInfo.GetComponent<Terumbu>();

        if(hitInfo.gameObject.CompareTag("TerumbuKarang")) {
            terumbu.Explode();

            //bombexplosion.Play();
            Debug.Log("I hit terumbu karang");
            Destroy(gameObject);
        }

        Debug.Log(hitInfo.name);
        //bombsound.PlayOneShot(Sound);
        
        Destroy(gameObject);

        
    }

}
