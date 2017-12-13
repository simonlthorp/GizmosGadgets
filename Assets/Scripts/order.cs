using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class order : MonoBehaviour {
    bool inTrigger;
    int colorLevel;

    public static int MAX_HP = 5;
    public static int PlayerHp = MAX_HP; //reference for HP
    public static bool orderReceived = false;

    public bool timeout;

    // Use this for initialization
    void Start () {
        colorLevel = 1;
        timeout = false;
	}

    //base increase 10
    //additional 10 for secondary colours
    //10 times level

    // Update is called once per frame
    void Update () {
        if (Input.GetButton("Fire1") && inTrigger) {
            if (globalVars.carry) {
                if(globalVars.orderShape==globalVars.gadShape && globalVars.orderColor == globalVars.gadColor) {
                    globalVars.score += ((globalVars.level * 10) + (10 * colorLevel));
                    globalVars.ResetGadget();
                }
                else {
                    if (PlayerHp > 0)
                    {
                        PlayerHp -= 1; // damages!!
                        Debug.Log("*" + PlayerHp);
                    }
                        Debug.Log("Boo");
                        globalVars.ResetGadget();                  
                    }
                    orderReceived = true;
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

    public void loseHealth()
    {


        PlayerHp -= 1; // damages!!
        Debug.Log("*" + PlayerHp);
        timeout = false;

    }

}
