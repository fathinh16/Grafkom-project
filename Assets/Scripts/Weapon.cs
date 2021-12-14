using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefabs;

    public AudioSource audioSource;
    public AudioClip shootingAudioClip;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) {
            Shoot();
        }        
    }

    void Shoot () {
        //shooting logic
        audioSource.PlayOneShot(shootingAudioClip);
        Instantiate(bulletPrefabs, firepoint.position, firepoint.rotation, firepoint);
        bulletPrefabs.transform.SetParent (null) ;
    }
}
