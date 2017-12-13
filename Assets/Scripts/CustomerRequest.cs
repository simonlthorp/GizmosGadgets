using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerRequest : MonoBehaviour {

    private int colorRand = 0;
    private int objectRand = 0;
    private GameObject color;
    private GameObject colorRequest;
    private GameObject objectRequest;
    private GameObject objectReq;
    public GameObject sound1;
    public GameObject sound2;
    public GameObject sound3;
    private int colorDifficulty; // can be between 1 and 6

	// Use this for initialization
	void Start () {
        sound1 = GameObject.Find("Sound1");
        sound2 = GameObject.Find("Sound2");
        sound3 = GameObject.Find("Sound3");
        colorDifficulty = 6; // difficulty determines number of colors possible
        ChooseColor(colorDifficulty);

        ChooseObject();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ClearRequest()
    {
        objectReq.SetActive(false);
        color.SetActive(false);
    }

    // Randomly chooses an object request and activates it
    public void ChooseObject()
    {
        System.Random rand = new System.Random();

        objectRand = rand.Next(0, 3);

        //Debug.Log(objectRand);

        if(objectRand == 0) //Sphere
        {
            objectRequest = this.transform.Find("ObjectRequest").gameObject;
            objectReq = objectRequest.transform.Find("Sphere").gameObject;
            globalVars.orderShape = "Sphere";
            sound1.GetComponent<AudioSource>().Play();
        }
        else if(objectRand == 1) //Cone
        {
            objectRequest = this.transform.Find("ObjectRequest").gameObject;
            objectReq = objectRequest.transform.Find("Cone").gameObject;
            globalVars.orderShape = "Cone";
            sound2.GetComponent<AudioSource>().Play();
        }
        else if (objectRand == 2) //Diamond
        {
            objectRequest = this.transform.Find("ObjectRequest").gameObject;
            objectReq = objectRequest.transform.Find("Diamond").gameObject;
            globalVars.orderShape = "Diamond";
            sound3.GetComponent<AudioSource>().Play();
        }

        objectReq.SetActive(true);
    }

    // Randomly chooses a color request and activates it
    public void ChooseColor(int colorDificulty)
    {

        System.Random rand = new System.Random();

        colorRand = rand.Next(0, colorDificulty);

        //Debug.Log("Rand is " + colorRand);

        if (colorRand == 0)//Red
        {
            colorRequest = this.transform.Find("ColorRequest").gameObject;
            color = colorRequest.transform.Find("Red").gameObject;
            globalVars.orderColor = "Red";
        }
        else if(colorRand == 1)//Blue
        {
            colorRequest = this.transform.Find("ColorRequest").gameObject;
            color = colorRequest.transform.Find("Blue").gameObject;
            globalVars.orderColor = "Blue";
        }
        else if(colorRand == 2)//Yellow
        {
            colorRequest = this.transform.Find("ColorRequest").gameObject;
            color = colorRequest.transform.Find("Yellow").gameObject;
            globalVars.orderColor = "Yellow";
        }
        else if(colorRand == 3)//Green
        {
            colorRequest = this.transform.Find("ColorRequest").gameObject;
            color = colorRequest.transform.Find("Green").gameObject;
            globalVars.orderColor = "Green";
        }
        else if(colorRand == 4)//Purple
        {
            colorRequest = this.transform.Find("ColorRequest").gameObject;
            color = colorRequest.transform.Find("Purple").gameObject;
            globalVars.orderColor = "Purple";
        }
        else if(colorRand == 5)//Orange
        {
            colorRequest = this.transform.Find("ColorRequest").gameObject;
            color = colorRequest.transform.Find("Orange").gameObject;
            globalVars.orderColor = "Orange";
        }

        color.SetActive(true);
    }

}
