using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatGadgetSound : MonoBehaviour {

    AudioSource audioSource;
    bool inTrigger;

    // Use this for initialization

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inTrigger)
        {
            audioSource.Play();
            
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "torso")
        {
            inTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "torso")
        {
            inTrigger = false;
        }
    }
}
