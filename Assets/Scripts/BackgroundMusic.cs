using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {

    AudioSource audioSource;
    public AudioClip[] clips;

    // Use this for initialization
    IEnumerator Start () {
        int trackNumber = 0;
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.clip = clips[trackNumber];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length*2);
        audioSource.clip = clips[++trackNumber % clips.Length];
        audioSource.Play();
    }
	
	// Update is called once per frame
	void Update () {        

	}
}
