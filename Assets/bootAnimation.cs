using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bootAnimation : MonoBehaviour {
    Animator ani;
	// Use this for initialization
	void Start () {
        ani = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Animation");
            ani.SetBool("bootAnimation", false);
            
        }
	}
}
