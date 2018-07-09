using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioClip : MonoBehaviour {

    public class Game : MonoBehaviour
    {
        public AudioClip audioClip;
        private AudioSource audioSource;
        private void Awake()
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = audioClip;
            StartCoroutine(PlayAudioSource(20, 5));
        }


        IEnumerator PlayAudioSource(float startTime, float stopTime)
        {
            audioSource.time = startTime;
            audioSource.Play();
            yield return new WaitForSeconds(stopTime - startTime);
            audioSource.Stop();
        }


    }
}
