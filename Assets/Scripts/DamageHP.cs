using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DamageHP : MonoBehaviour
{
    /*
    public int PlayerHp = 5; //reference for HP
    public GameObject[] HP = new GameObject[5]; // reference for HP objects
                                               
  

    // Use this for initialization
    void Start()
    {
        Debug.Log("start");
        PlayerHp = 5; //reference for HP
        GameObject[] HP = new GameObject[5]; // reference for HP objects
    }

    // Update is called once per frame
    void Update()
    {
        damage();
    }

    public void damage()
    {
        if (globalVars.carry)
        {
            Debug.Log("Success");
        } else
        {
            if (PlayerHp > 0)
            {
                PlayerHp = PlayerHp - 1; // damages!!
                HP[PlayerHp].SetActive(false);
                Debug.Log(PlayerHp);
            }
        }

        if (PlayerHp == 0)
        {

        }
    }
    */

    private int playerHp = 5;
    private GameObject hpSprite;
    //private Scene gameOver;

    private void Start()
    {
        //gameOver = 
    }


    private void Update()
    {
        if (order.PlayerHp != playerHp)
        {
            playerHp = order.PlayerHp;

            if (playerHp == 4)
            {
                hpSprite = this.transform.Find("Heart (4)").gameObject;
                hpSprite.SetActive(false);
            }
            else if(playerHp == 3)
            {
                hpSprite = this.transform.Find("Heart (3)").gameObject;
                hpSprite.SetActive(false);
            }
            else if (playerHp == 2)
            {
                hpSprite = this.transform.Find("Heart (2)").gameObject;
                hpSprite.SetActive(false);
            }
            else if (playerHp == 1)
            {
                hpSprite = this.transform.Find("Heart (1)").gameObject;
                hpSprite.SetActive(false);
            }
            else if (playerHp == 0)
            {
                SceneManager.LoadScene("gameover", LoadSceneMode.Single);
                order.PlayerHp = order.MAX_HP;
            }
        }
    }
}
