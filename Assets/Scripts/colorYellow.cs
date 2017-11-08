using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorYellow : MonoBehaviour {

    public Material Yellow, Orange;
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
                    r.material = Orange;
                    globalVars.Orange = true;
                }
                else {
                    r.material = Yellow;
                    globalVars.Yellow = true;
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
                Debug.Log("lo");
            }


        }

    }

    void OnTriggerExit(Collider other) {
        under = false;
    }
}
