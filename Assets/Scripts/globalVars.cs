using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalVars : MonoBehaviour {

    public static bool switchFlippedA, switchFlippedB, switchFlippedC, switchFlippedD;
    public static bool Red, Orange, Yellow, Green, Blue, Purple;
    public static bool A, B, C, D, E, F;
    public static string gadName;
    bool end;
    public static bool movement;
    public static bool help;
    public GameObject s1, s2, s3, cR, cY, cB;
    public static GameObject shape1, shape2, shape3, colRed, colYel, colBlu;
    public static int score;
    public static string gadShape, gadColor, orderShape, orderColor;
    public static bool carry;
    public static GameObject deployedGadget;

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
        movement = false;
        help = false;

        shape1 = s1;
        shape2 = s2;
        shape3 = s3;
        colRed = cR;
        colYel = cY;
        colBlu = cB;
        score = 0;

        carry = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public static void acivate(bool a) {
        if(a == true) {
            shape1.GetComponent<shapeSphere>().enabled = true;
            shape2.GetComponent<shapeTriangle>().enabled = true;
            shape3.GetComponent<shapeDiamond>().enabled = true;
            colRed.GetComponent<colorREd>().enabled = true;
            colBlu.GetComponent<colorBlue>().enabled = true;
            colYel.GetComponent<colorYellow>().enabled = true;
        }
        else {
            shape1.GetComponent<shapeSphere>().enabled = false;
            shape2.GetComponent<shapeTriangle>().enabled = false;
            shape3.GetComponent<shapeDiamond>().enabled = false;
            colRed.GetComponent<colorREd>().enabled = false;
            colBlu.GetComponent<colorBlue>().enabled = false;
            colYel.GetComponent<colorYellow>().enabled = false;
        }

    }
}
