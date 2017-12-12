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
    int hi = 0;
    int copyNum = 0;

    private customerMove cm;
    private int currentLevel;

    // Use this for initialization
    void Start () {

        cm = GameObject.Find("CustomerHead").GetComponent<customerMove>();

	}
	
	// Update is called once per frame
    
	void Update () {

        //By: Johnny Kang, grabs the level variable from the customerMove.cs and stores it into currentlevel variable of this script file
        currentLevel = (int)cm.level;

            if (globalVars.switchFlippedA) {
            A1 = false;
            B1 = false;
            C1 = false;
            orderGadget = (GameObject)Instantiate(Gadget, new Vector3(4, 1.5f, -3), Gadget.transform.rotation);
                orderGadget.tag = "1Gadget";
                copyNum++;
            //                string name = string.Concat("orderGadget",copyNum);
            globalVars.gadName = string.Concat("orderGadget", copyNum);
                orderGadget.name = globalVars.gadName;
                meow = true;
            start = true;
                globalVars.switchFlippedA = false;
            globalVars.movement = true;
            globalVars.help = true;
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
            Debug.Log("level: " + currentLevel);

            //By Johnny Kang: grabs the currentlevel variable and adds to the speed of the conveyor belt varying on the current level
            step = Time.deltaTime*(2+currentLevel/2);

            if (start) {
                orderGadget.transform.position = Vector3.MoveTowards(orderGadget.transform.position, A, step);
            }
            if (orderGadget.transform.position == A) {
                start = false;
                A1 = true;
            }

            if (A1) {
                orderGadget.transform.position = Vector3.MoveTowards(orderGadget.transform.position, B, step);

            }

            if (orderGadget.transform.position == B) {
                B1 = true;
                A1 = false;
            }
            if (B1) {
                orderGadget.transform.position = Vector3.MoveTowards(orderGadget.transform.position, C, step);
            }

            if (orderGadget.transform.position == C) {
                C1 = true;
                B1 = false;
            }

            if (C1) {
                orderGadget.transform.position = Vector3.MoveTowards(orderGadget.transform.position, D, step);
            }
            if (orderGadget.transform.position == D) {
                meow = false;
                C1 = false;
            }
        }
    }

    void OnTriggerEnter(Collider other) {

    }
}
