using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class order : MonoBehaviour {
    bool inTrigger;
    int colorLevel;

    public static int MAX_HP = 5;
    public static int PlayerHp = MAX_HP; //reference for HP
    public static bool orderReceived = false;

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
                        globalVars.gadShape = null;

                        globalVars.Red = false;
                        globalVars.Orange = false;
                        globalVars.Yellow = false;
                        globalVars.Green = false;
                        globalVars.Blue = false;
                        globalVars.Purple = false;
                    }
                    else {

                        if (PlayerHp > 0)
                        {
                            PlayerHp -= 1; // damages!!
                            Debug.Log("*" + PlayerHp);
                        }

                        Debug.Log("Boo");
                        Destroy(globalVars.deployedGadget);
                        globalVars.carry = false;
                        globalVars.help = false;
                        globalVars.movement = false;
                        globalVars.acivate(false);
                        globalVars.gadShape = null;

                        globalVars.Red = false;
                        globalVars.Orange = false;
                        globalVars.Yellow = false;
                        globalVars.Green = false;
                        globalVars.Blue = false;
                        globalVars.Purple = false;

                    }

                    orderReceived = true;

                }
                
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
