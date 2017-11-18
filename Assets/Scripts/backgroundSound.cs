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
            if (Input.GetAxisRaw("Pause") !=0 )
            {
                audioSource.Pause();

            }
        }
        else if (!audioSource.isPlaying)
        {
            if (Input.GetAxis("Pause") != 0)
            {
                audioSource.Play();
            }
        }
    }
}
