using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPathNav : MonoBehaviour
{
    public GameObject wpManager;
    // Array of waypoints
    GameObject[] wps;

    private NavMeshAgent agent;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        wps = wpManager.GetComponent<WPManager>().waypoints;
    }

    public void GoToHeli()
    {
        agent.SetDestination(wps[1].transform.position);
        //g.AStar(currentNode, wps[1]);
    }

    public void GoToRuin()
    {
        agent.SetDestination(wps[6].transform.position);
        //g.AStar(currentNode, wps[6]);
    }

    public void GoToTanks()
    {
        agent.SetDestination(wps[8].transform.position);
        //g.AStar(currentNode, wps[8]);
    }

    // Update is called once per frame
    void LateUpdate()
    {


    }
}
