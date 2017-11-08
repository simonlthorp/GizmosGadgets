using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class order : MonoBehaviour {
    bool inTrigger;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Fire1") != 0 && inTrigger) {
            if (Input.GetAxisRaw("Fire1") != 0) {
                Debug.Log("Order: Red Sphere");
            }
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "torso") {
            inTrigger = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.name == "torso") {
            inTrigger = false;
        }
    }
}
