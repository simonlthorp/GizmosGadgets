using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorBlue : MonoBehaviour {

    public Material Blue, Green, Purple;
    GameObject gadget;
    bool active;
    bool under;

	// Use this for initialization
	void Start () {
        gadget = GameObject.Find("Gadget");
        active = false;
        under = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (active) {
            Renderer[] renderers = gadget.GetComponentsInChildren<Renderer>();
            foreach (var r in renderers) {
                if (globalVars.Red) {
                    r.material = Purple;
                    globalVars.Purple = true;
                }
                else if (globalVars.Yellow) {
                    r.material = Green;
                    globalVars.Green = true;
                }
                else {
                    r.material = Blue;
                }

            }
            active = false;
        }
	}

    void OnTriggerStay(Collider other) {
        under = true;
        if (other.gameObject.name == "Gadget") {

            if (globalVars.switchFlippedC) {
                active = true;
                globalVars.switchFlippedC = false;
            }


        }

    }

    void onTriggerExit(Collider other) {
        under = false;
    }
}
