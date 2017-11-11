using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorREd : MonoBehaviour {

    public Material Red;
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
    void Update() {
        
        if (active) {
            Renderer[] renderers = gadget.GetComponentsInChildren<Renderer>();
            foreach (var r in renderers) {
                    r.material = Red;
                    globalVars.Red = true;
                globalVars.gadColor = "Red";
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

    void OnTriggerExit(Collider other) {
        under = false;
    }
}
