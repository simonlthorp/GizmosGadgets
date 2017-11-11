using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerRequest : MonoBehaviour {

    private int colorRand = 0;
    private int objectRand = 0;
    private GameObject color;

	// Use this for initialization
	void Start () {

        System.Random rand = new System.Random();
        
        objectRand = rand.Next(0, 2);

        ChooseColor(colorRand);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ChooseColor(int randomColor)
    {

        System.Random rand = new System.Random();

        colorRand = rand.Next(0, 5);

        Debug.Log("Rand is " + colorRand);

        if (randomColor == 0)
        {
            color = GameObject.Find("Red");
            color.SetActive(true);
        }
        else if(randomColor == 1)
        {
            color = GameObject.Find("Purple");
            color.SetActive(true);
        }
        else if(randomColor == 2)
        {
            color = GameObject.Find("Orange");
            color.SetActive(true);
        }
        else if(randomColor == 3)
        {
            color = GameObject.Find("Green");
            color.SetActive(true);
        }
        else if(randomColor == 4)
        {
            color = GameObject.Find("Blue");
            color.SetActive(true);
        }
        else if(randomColor == 5)
        {
            color = GameObject.Find("Yellow");
            color.SetActive(true);
        }
    }

}
