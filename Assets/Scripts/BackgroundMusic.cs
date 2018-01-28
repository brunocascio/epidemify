using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {

    AudioSource audioSource;
    public AudioClip[] clips;
    int head = 0;
    int interval = 20;

    // Use this for initialization
    IEnumerator Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clips[0];
        for (int i = 0; i < clips.Length; i++) {
            if (head > clips[i].length) {
                head = 0;
            };
            audioSource.time = head;
            audioSource.Play();
            yield return new WaitForSeconds(interval);
            head = head + interval;
            audioSource.clip = clips[i % clips.Length];
            if (i == clips.Length - 1) {
                audioSource.loop = true;
                audioSource.Play();
            }
        }
    }
	
	// Update is called once per frame
	void Update () {        

	}
}
