using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveGadget : MonoBehaviour {

    bool A1, B1, C1;
    bool start;
    bool meow=false;
    public float step;
    public GameObject Gadget;
    GameObject orderGadget;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
    
	void Update () {
        if (globalVars.switchFlippedA) {
            A1 = false;
            B1 = false;
            C1 = false;
            //orderGadget = (GameObject)Instantiate(Gadget, new Vector3(4, 1.5f, -3), Gadget.transform.rotation);
            //    orderGadget.tag = "1Gadget";
            //    copyNum++;
            ////                string name = string.Concat("orderGadget",copyNum);
            //globalVars.gadName = string.Concat("orderGadget", copyNum);
            //    orderGadget.name = globalVars.gadName;
            Gadget.transform.position = new Vector3(4, 1.5f, -3);
            start = true;
            globalVars.switchFlippedA = false;
            globalVars.movement = true;
        }
        //if (globalVars.switchFlippedA && hi==0) {
        //    orderGadget = (GameObject)Instantiate(Gadget, Gadget.transform.position, Gadget.transform.rotation); 
        //    meow = true;
        //    globalVars.switchFlippedA = false;
        //    hi += 1;
        //}d

        if (globalVars.movement) {
            Vector3 A = new Vector3(-4, 1.45f, -3);
            //  Vector3 A = new Vector3(1.5f, 1.45f, -3);

            Vector3 B = new Vector3(-4, 1.45f, -0.5f);
            Vector3 C = new Vector3(4, 1.45f, -0.5f);
            Vector3 D = new Vector3(4, 1.45f, 1.5f);

            step = Time.deltaTime*2;

            if (start) {
                Gadget.transform.position = Vector3.MoveTowards(Gadget.transform.position, A, step);
            }
            if (Gadget.transform.position == A) {
                start = false;
                A1 = true;
            }

            if (A1) {
                Gadget.transform.position = Vector3.MoveTowards(Gadget.transform.position, B, step);
            }

            if (Gadget.transform.position == B) {
                B1 = true;
                A1 = false;
            }
            if (B1) {
                Gadget.transform.position = Vector3.MoveTowards(Gadget.transform.position, C, step);
            }

            if (Gadget.transform.position == C) {
                C1 = true;
                B1 = false;
            }

            if (C1) {
                Gadget.transform.position = Vector3.MoveTowards(Gadget.transform.position, D, step);
            }
            if (Gadget.transform.position == D) {
                C1 = false;
                globalVars.movement = false;
            }
        }
    }

    void OnTriggerEnter(Collider other) {

    }
}
