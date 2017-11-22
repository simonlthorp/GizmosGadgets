using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundSound : MonoBehaviour {

    AudioSource audioSource;
    // Use this for initialization
    void Start () {

    audioSource = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {

        if (audioSource.isPlaying)
        {
            if (Input.GetKeyDown("joystick button 7") || Input.GetKeyDown("q"))
            {
                audioSource.Pause();

            }
           
        }
        else if (!audioSource.isPlaying)
        {
            if (Input.GetKeyDown("joystick button 7") || Input.GetKeyDown("q"))
            {
                audioSource.Play();
            }
           
        }
    }
}
