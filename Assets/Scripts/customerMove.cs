using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class customerMove : MonoBehaviour
{
    public float timeLeft;
    public Transform target3;
    public Transform target2;
    public Transform target;
    public bool angry = false;
    public bool happy = false;
    public Transform exit;
    NavMeshAgent agent;
    public Transform gohere;
    public GameObject request;
    public float level = 0;
    public int levelreq = 10;
    Rigidbody cbody;
    bool reset = true;
    public float resetter = 7;
    public moveGadget editspeed;
    // Use this for initialization
    void Start()
    {
        cbody = GetComponent<Rigidbody>();
        timeLeft = 5;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;

        request = GameObject.Find("CustomerRequest");

    }

    // Update is called once per frame
    void Update()
    {
        if (levelreq == 0) {
            level++;
            editspeed.step = Time.deltaTime * (3 + level);
            levelreq = 10;
            agent.speed = 3.5f + level;
        }

        if (reset == true)
        {
            timeLeft = 20 - level;
            angry = false;
            happy = false;
            chooseSpace();
            agent.SetDestination(gohere.position);
            reset = false;
        }

        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            angry = true;

            if (angry == true)
            {

                gohere = exit;
                agent.SetDestination(gohere.position);

                resetter -= Time.deltaTime;
                if (resetter <= 0)
                {
                    resetter = 5;
                    reset = true;
                    angry = false;
                    order.orderReceived = false;

                    request.GetComponent<CustomerRequest>().ClearRequest();
                    request.GetComponent<CustomerRequest>().ChooseObject();
                    request.GetComponent<CustomerRequest>().ChooseColor(6);

                    
                }
            }

            if (order.orderReceived) {

                happy = true;
                if (happy == true) {

                    gohere = exit;
                    agent.SetDestination(gohere.position);

                    resetter -= Time.deltaTime;
                    if (resetter <= 0)
                    {
                        resetter = 5;
                        reset = true;
                        happy = false;
                        order.orderReceived = false;

                        request.GetComponent<CustomerRequest>().ClearRequest();
                        request.GetComponent<CustomerRequest>().ChooseObject();
                        request.GetComponent<CustomerRequest>().ChooseColor(6);

                        levelreq--;
                    }


                }
            }
        }

    }

    void chooseSpace()
    {
        System.Random ran = new System.Random();

        int i = ran.Next(0, 3);

        if (i == 0)
        {
            gohere = target;
            Debug.Log("i is 0");
        }
        else if (i == 1)
        {
            gohere = target2;
            Debug.Log("i is 1");
        }
        else if (i == 2)
        {

            gohere = target3;
            Debug.Log("i is 2");
        }

    }
}
