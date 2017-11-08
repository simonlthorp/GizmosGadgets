using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveGizmo : MonoBehaviour {
    private Rigidbody rb;
    bool faceMachine;
    int turn = 1;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        faceMachine = false;

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


        rb.transform.Translate(movement / 7.5f);
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Gadget") {
        }    
    }

}
