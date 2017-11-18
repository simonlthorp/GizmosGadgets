using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorBlue : MonoBehaviour {

    public Material Blue, Green, Purple;
    GameObject gadget;
    bool active;
    bool under;

	// Use this for initialization
	void OnEnable() {
        gadget = GameObject.Find(globalVars.gadName);
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
                    globalVars.gadColor = "Purple";

                }
                else if (globalVars.Yellow) {
                    r.material = Green;
                    globalVars.Green = true;
                    globalVars.gadColor = "Green";

                }
                else {
                    r.material = Blue;
                    globalVars.gadColor = "Blue";
                }

            }
            active = false;
        }
    }

    void OnTriggerStay(Collider other) {
        under = true;
        if (other.gameObject.tag == "1Gadget") {

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
