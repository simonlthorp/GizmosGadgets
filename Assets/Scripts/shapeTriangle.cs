using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeTriangle : MonoBehaviour {

    bool active;
    bool under;
    private GameObject parent;
    Renderer rendCap, rendTri;


    // Use this for initialization
    void OnEnable() {
        parent = GameObject.Find(globalVars.gadName);
        rendCap = parent.transform.Find("gadCapsule").GetComponent<Renderer>();
        rendTri = parent.transform.Find("gadCone").GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update() {

        if (active) {
            if (globalVars.gadShape == null) {
                Debug.Log("CONE");
                rendCap.enabled = false;
                rendTri.enabled = true;
                globalVars.gadShape = "Cone";

            }

        }

    }

    void OnTriggerStay(Collider other) {
        under = true;
        if (other.gameObject.name == globalVars.gadName) {
            if (globalVars.switchFlippedB) {
                active = true;
                globalVars.switchFlippedB = false;
                Debug.Log("Falsed + C");
            }

        }
    }

    void OnTriggerExit(Collider other) {
        Debug.Log("T");
        under = false;
        active = false;
    }
}
