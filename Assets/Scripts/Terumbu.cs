using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Terumbu : MonoBehaviour
{
    float delay =5f;
    public int damage1 = 20;
    private GameObject player;
//    public AudioSource audioSource1;
//    public AudioClip explosionSound;
    [SerializeField] private AudioSource bombexplosion;
    [SerializeField] private GameObject _replacement;

    void Start() {
        player = GameObject.Find("Dewa Laut");
    }

    // Update is called once per frame
    public void Explode()
    {
        Debug.Log("terumbu karang mati:(");
        //audioSource1.PlayOneShot(explosionSound);
                    bombexplosion.Play();
        Dewascript pscript = player.GetComponent<Dewascript>();
        pscript.TakeDamage(damage1);
        Instantiate(_replacement, transform.position, transform.rotation,transform);
        Destroy(gameObject,delay);
        //add efek mati jadi hitam
        //hapus marks
    }
}
