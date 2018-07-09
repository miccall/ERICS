using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitch : MonoBehaviour {

    private AudioSource audiosource;
	void Start () {
        audiosource = this.GetComponent<AudioSource>();
        if (!audiosource.isPlaying)
        {
            audiosource.Play();
        }
		DontDestroyOnLoad(audiosource);
        
	}
	
	
}
