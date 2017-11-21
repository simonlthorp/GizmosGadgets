using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropFlip : MonoBehaviour {
    bool act = false;
    bool inTrigger;
    private bool axisInUse = false;
    public GameObject shape1, shape2, shape3, colRed, colYel, colBlu;
    // Use this for initialization
    void Start() {
        globalVars.acivate(false);
        //shape1.GetComponent<shapeSphere>().enabled = false;
        //shape2.GetComponent<shapeTriangle>().enabled = false;
        //shape3.GetComponent<shapeDiamond>().enabled = false;
        //colRed.GetComponent<colorREd>().enabled = false;
        //colBlu.GetComponent<colorBlue>().enabled = false;
        //colYel.GetComponent<colorYellow>().enabled = false;
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetAxisRaw("Fire1") != 0 && inTrigger) {
            if (axisInUse == false) {


                if (globalVars.help) {
                    globalVars.acivate(true);
                    shape1.GetComponent<shapeSphere>().enabled = true;
                    shape2.GetComponent<shapeTriangle>().enabled = true;
                    shape3.GetComponent<shapeDiamond>().enabled = true;
                    colRed.GetComponent<colorREd>().enabled = true;
                    colBlu.GetComponent<colorBlue>().enabled = true;
                    colYel.GetComponent<colorYellow>().enabled = true;
                    axisInUse = true;

                }
                else {
                    globalVars.switchFlippedA = true;
                }


            }

 //               Debug.Log("Activate Drop");
        }
        if (Input.GetAxisRaw("Fire1") == 0) {
            axisInUse = false;
        }

        //if (Input.GetAxis("Fire1") == 0 && inTrigger) {
        //    if (Input.GetAxisRaw("Fire1") == 1) {
        //        if (axisInUse == false) {
        //            axisInUse = true;
        //            globalVars.switchFlippedA = true;
        //            Debug.Log("Activate Drop");
        //        }
        //    }
        //    else if(Input.GetAxisRaw("Fire1") == -1) {
        //        if (axisInUse == false) {
        //            axisInUse = true;
        //            globalVars.switchFlippedA = true;
        //            Debug.Log("Activate Drop");
        //        }
        //    }
        //}

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
