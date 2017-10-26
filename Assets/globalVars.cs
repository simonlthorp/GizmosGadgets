using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalVars : MonoBehaviour {

    public static bool switchFlippedA, switchFlippedB, switchFlippedC, switchFlippedD;
    public static bool Red, Orange, Yellow, Green, Blue, Purple;
    public static bool A, B, C, D, E, F;

	// Use this for initialization
	void Start () {
        switchFlippedA = false;
        switchFlippedB = false;
        switchFlippedC = false;
        switchFlippedD = false;

        Red = false;
        Orange = false;
        Yellow = false;
        Green = false;
        Blue = false;
        Purple = false;

        A = false;
        B = false;
        C = false;
        D = false;
        E = false;
        F = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
