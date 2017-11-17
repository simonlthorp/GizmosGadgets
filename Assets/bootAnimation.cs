using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bootAnimation : MonoBehaviour {
    public Animator ani;
    
    //bool act = false;
    //bool inTrigger;
    // Use this for initialization
    void Start () {

        ani = GetComponent<Animator>();
       
	}

    // Update is called once per frame
    void Update() {

        //if (Input.GetKeyDown(KeyCode.Z))
        //{
        //    Debug.Log("Animation");
        //    ani.Play("bootAnimation");

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
        if (Input.GetKeyDown(KeyCode.E)) //&& inTrigger)
        {

            Debug.Log("aaaa");
            ani.Play("bootAnimation");

        }
    }
    //void OnTriggerEnter(Collider other)
    //    {
    //        if (other.gameObject.name == "torso")
    //        {
    //            inTrigger = true;
    //        }
    //    }

    //    void OnTriggerExit(Collider other)
    //    {
    //        if (other.gameObject.name == "torso")
    //        {
    //            inTrigger = false;
    //        }
    //    }

    
}
