using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class order : MonoBehaviour {
    bool inTrigger;
    int colorLevel;
    // Use this for initialization
    void Start () {
        colorLevel = 1;
	}

    //base increase 10
    //additional 10 for secondary colours
    //10 times level

    // Update is called once per frame
    void Update () {
        if (Input.GetAxis("Fire1") != 0 && inTrigger) {
            if (Input.GetAxisRaw("Fire1") != 0) {
                if (globalVars.carry) {
                    if(globalVars.orderShape==globalVars.gadShape && globalVars.orderColor == globalVars.gadColor) {
                        Debug.Log("SUCCESSS");
                        globalVars.score += ((globalVars.level * 10) + (10 * colorLevel));
                        Destroy(globalVars.deployedGadget);
                        globalVars.carry = false;
                        globalVars.help = false;
                        globalVars.movement = false;
                        globalVars.acivate(false);

                    }
                }
                Debug.Log("Order: Red Sphere");
                globalVars.orderColor = "Red";
                globalVars.orderShape = "Sphere";
                
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
