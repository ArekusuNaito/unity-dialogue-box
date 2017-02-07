using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMaster : MonoBehaviour {

	public AudioSource musicSource;
	public AudioSource sfxSource;
	

	public static  void playSFX(AudioClip sfxClip)
	{
		
		instance.sfxSource.PlayOneShot(sfxClip);
	}

	public static  void playMusic(AudioClip musicClip)
	{
		instance.musicSource.clip = musicClip;
		instance.musicSource.Play();
	}



	public static SoundMaster instance = null;
	void Awake () 
	{
		if(instance == null)
		{
			instance = this;
		}
		else if(instance != this)
		{
			Destroy(this.gameObject);
		}
		DontDestroyOnLoad(gameObject);
		
	}

}