using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXmanager : MonoBehaviour
{

	public AudioSource Audio;

	public AudioClip click;

	public static SFXmanager sfxInstance;
 
    private void Awake()
    {
    	if (sfxInstance != null && sfxInstance != this)
    	{
    		Destroy(this.gameObject);
    		return;
    	}

    	sfxInstance = this;
    	DontDestroyOnLoad(this);
    }
}
