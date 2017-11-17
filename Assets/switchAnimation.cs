using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchAnimation : MonoBehaviour {
    public Animator anim;
    bool act = false;
    bool inTrigger;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && inTrigger)
        {

            anim.Play("SwitchAnimation");
        }
        //if (Input.GetKeyDown(KeyCode.E)) //&& inTrigger)
        //{

        //    Debug.Log("aaaa");
        //    anim.Play("SwitchAnimation");

        //}
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "torso")
        {
            inTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "torso")
        {
            inTrigger = false;
        }
    }
}
