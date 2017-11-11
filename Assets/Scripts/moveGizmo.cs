﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveGizmo : MonoBehaviour {
    private Rigidbody rb;
    GameObject obj;
    bool faceMachine;
    int turn = 1;
    bool objGet;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        faceMachine = false;
        objGet = false;
    }

    // Update is called once per frame
    void FixedUpdate () {
        Vector3 clampedPositionA = transform.position;
        clampedPositionA.x = Mathf.Clamp(transform.position.x, -4, 4);
        transform.position = clampedPositionA;

        float moveVertical = Input.GetAxis("Vertical");


        if (moveVertical<0) {
            transform.rotation = Quaternion.Euler(0,180,0);
            turn = -1;
        }
        else if (moveVertical>0) {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            turn = 1;
        }
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3((turn*moveHorizontal), 0.0f, 0.0f);

        if (globalVars.carry) {

            globalVars.acivate(false);
            globalVars.help = false;
            Debug.Log("helloo");
            globalVars.deployedGadget.gameObject.transform.position = new Vector3(transform.position.x, (transform.position.y + 0.5f), transform.position.z);
        }

        rb.transform.Translate(movement / 7.5f);
    }

    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "1Gadget") {
            objGet = true;
            globalVars.carry = true;
            globalVars.deployedGadget = other.gameObject;
            Debug.Log("Shape: " + globalVars.gadShape);
            Debug.Log("Color: " + globalVars.gadColor);
        }
    }

}