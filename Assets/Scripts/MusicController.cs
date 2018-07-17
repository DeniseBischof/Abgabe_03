using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {


    AudioSource audioSource;
    public AudioClip song;


	// Use this for initialization
	void Start () {
        
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = song;
        audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
