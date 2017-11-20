using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bootAnimation : MonoBehaviour {
    //Animator ani;
    public Animator anim;
    bool act = false;
    bool inTrigger;

    void Start () {

        //anim = GetComponent<Animator>();
      //  GameObject boot= GameObject.Find("BootSwitch");
       // anim = boot.GetComponent<Animator>();
       
	}

    // Update is called once per frame
    void Update() {

        //if (Input.GetKeyDown(KeyCode.Z))
        //{
        //    Debug.Log("Animation");
        //    anim.Play("bootAnimation");

        //}
        //if (Input.GetAxis("Fire1") != 0 && inTrigger)
        //{
        //    if (Input.GetAxisRaw("Fire1") != 0)
        //    {

        //        globalVars.switchFlippedD = true;
        //        Debug.Log("aaaa");
        //              ani.Play("bootAnimation");
        //    }
        //}

        if (Input.GetAxisRaw("Fire1") != 0 && inTrigger)
        {

            Debug.Log("aaaa");
            anim.Play("bootAnimation");

        }
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
