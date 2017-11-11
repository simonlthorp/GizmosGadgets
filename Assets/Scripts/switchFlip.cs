using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class switchFlip : MonoBehaviour {

    public static TextMesh text;
    public static MeshRenderer tm;
    // Use this for initialization
    void Start () {
        text = GameObject.Find("tax").GetComponent<TextMesh>();
        tm = GameObject.Find("tax").GetComponent<MeshRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other) {
        Debug.Log("Enter: " + other.gameObject.name);
    }


    void OnTriggerExit(Collider other) {
        Debug.Log("Exit: " + other.name);

    }
}
