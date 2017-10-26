using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeTriangle : MonoBehaviour {

    // Use this for initialization

    Transform capObj, triObj, sphObg, diaObj;
	void Start () {

        capObj = transform.Find("Capsule");
        sphObg = transform.Find("Sphere");

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Gadget") {

        }
    }
}
