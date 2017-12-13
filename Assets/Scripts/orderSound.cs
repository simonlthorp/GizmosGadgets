using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orderSound : MonoBehaviour {
    AudioSource audioSource;
    public GameObject other;
    
    bool inTrigger;
    int colorLevel;

    public static int MAX_HP = 5;
    public static int PlayerHp = MAX_HP;
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
        other = GameObject.Find("OrderWrongSound");
        colorLevel = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetKeyDown("e") && inTrigger)||(Input.GetKeyDown("joystick button 2") && inTrigger))
        {
            if (Input.GetAxisRaw("Fire1") != 0)
            {
                if (globalVars.carry)
                {
                    if (globalVars.orderShape == globalVars.gadShape && globalVars.orderColor == globalVars.gadColor)
                    {
                        audioSource.Play();


                    }
                    else
                    {
                        other.GetComponent<AudioSource>().Play();
                        

                    }
                }

            }
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
