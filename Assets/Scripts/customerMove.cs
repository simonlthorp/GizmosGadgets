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
    public Transform exit;
    NavMeshAgent agent;
    public Transform gohere;
    public int time;
    Rigidbody cbody;
    // Use this for initialization
    void Start()
    {
        cbody = GetComponent<Rigidbody>();
        timeLeft = 5;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;

        chooseSpace();
    }

    // Update is called once per frame
    void Update()
    {

        agent.SetDestination(gohere.position);


        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            angry = true;

            if (angry == true)
            {

                gohere = exit;

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
        }






    }
}
