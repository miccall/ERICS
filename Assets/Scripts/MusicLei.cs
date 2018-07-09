using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLei : MonoBehaviour
{

	private AudioSource audiosource;
	void Start () {
		audiosource = this.GetComponent<AudioSource>();
		if (!audiosource.isPlaying)
		{
			audiosource.Play();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
