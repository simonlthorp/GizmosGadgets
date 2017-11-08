using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveGadget : MonoBehaviour {

    bool A1 = false, B1=false, C1=false;
    bool start = true;
    float step;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (globalVars.switchFlippedA) {
            Vector3 A = new Vector3(-4, 1.45f, -3);
            //  Vector3 A = new Vector3(1.5f, 1.45f, -3);

            Vector3 B = new Vector3(-4, 1.45f, -0.5f);
            Vector3 C = new Vector3(4, 1.45f, -0.5f);
            Vector3 D = new Vector3(4, 1.45f, 1.5f);

            step = Time.deltaTime;

            if (start) {
                transform.position = Vector3.MoveTowards(transform.position, A, step);
            }
            if (transform.position == A) {
                start = false;
                A1 = true;
            }

            if (A1) {
                transform.position = Vector3.MoveTowards(transform.position, B, step);
            }

            if (transform.position == B) {
                B1 = true;
                A1 = false;
            }
            if (B1) {
                transform.position = Vector3.MoveTowards(transform.position, C, step);
            }

            if (transform.position == C) {
                C1 = true;
                B1 = false;
            }

            if (C1) {
                transform.position = Vector3.MoveTowards(transform.position, D, step);
            }
        }
    }

    void OnTriggerEnter(Collider other) {

    }
}
