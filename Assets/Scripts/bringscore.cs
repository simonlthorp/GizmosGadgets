using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bringscore : MonoBehaviour {

    public  Text scoring;
    

    public    int scoregetter;

    public int gameover;
	// Use this for initialization
	void Start () {

       // Reseting();

        PlayerPrefs.SetInt("saved", globalVars.score);
        scoregetter = PlayerPrefs.GetInt("saved");

        scoring.text = scoregetter.ToString();
        Rank();
        


        




    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Rank ()
    {
        Debug.Log("started");
        gameover = scoregetter;

        if (gameover > PlayerPrefs.GetInt("4"))
        {
            PlayerPrefs.SetInt("0", PlayerPrefs.GetInt("1"));
            PlayerPrefs.SetInt("1", PlayerPrefs.GetInt("2"));
            PlayerPrefs.SetInt("2", PlayerPrefs.GetInt("3"));
            PlayerPrefs.SetInt("3", PlayerPrefs.GetInt("4"));
            PlayerPrefs.SetInt("4", gameover);
        }
        if (gameover > PlayerPrefs.GetInt("3") && gameover < PlayerPrefs.GetInt("4"))
        {
            PlayerPrefs.SetInt("0", PlayerPrefs.GetInt("1"));
            PlayerPrefs.SetInt("1", PlayerPrefs.GetInt("2"));
            PlayerPrefs.SetInt("2", PlayerPrefs.GetInt("3"));
            PlayerPrefs.SetInt("3", gameover);
        }
        if (gameover > PlayerPrefs.GetInt("2") && gameover < PlayerPrefs.GetInt("3"))
        {
            PlayerPrefs.SetInt("0", PlayerPrefs.GetInt("1"));
            PlayerPrefs.SetInt("1", PlayerPrefs.GetInt("2"));
            PlayerPrefs.SetInt("2", gameover);
        }
        if (gameover > PlayerPrefs.GetInt("1") && gameover < PlayerPrefs.GetInt("2"))
        {
            PlayerPrefs.SetInt("0", PlayerPrefs.GetInt("1"));
            PlayerPrefs.SetInt("1", gameover);
        }
        if (gameover > PlayerPrefs.GetInt("0") && gameover < PlayerPrefs.GetInt("1"))
        {
            PlayerPrefs.SetInt("0", gameover);

        }

      /*  ranking.text = "Ranking\n" +
              "1. " + PlayerPrefs.GetInt("4") + "\n" +
               "2. " + PlayerPrefs.GetInt("3") + "\n" +
                "3. " + PlayerPrefs.GetInt("2") + "\n" +
                 "4. " + PlayerPrefs.GetInt("1") + "\n" +
                  "5. " + PlayerPrefs.GetInt("0"); */
    }

    public void Reseting ()
    {
        Debug.Log("Testing");
        PlayerPrefs.SetInt("0", 0);
        PlayerPrefs.SetInt("1", 0);
        PlayerPrefs.SetInt("2", 0);
        PlayerPrefs.SetInt("3", 0);
        PlayerPrefs.SetInt("4", 0);
        
    }
}
