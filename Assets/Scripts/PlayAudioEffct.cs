using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioEffct : MonoBehaviour {

    private AudioSource audiosource;
	void Start () {
        audiosource = GetComponent<AudioSource>();
	}

    public void PlayMusic()
    {
        audiosource.Play();
    }
}
