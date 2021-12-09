using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.AI;

public class AgentFlee : MonoBehaviour
{
    private NavMeshAgent greenAgent;
    public GameObject redAgent;
    public float EnemyDistanceRun = 4.0f;

    void Start()
    {
        greenAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, redAgent.transform.position);
        Debug.Log("Distance: " + distance);
        if(distance < EnemyDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - redAgent.transform.position;
            Vector3 newPosition = transform.position + dirToPlayer;
            greenAgent.SetDestination(newPosition);
        }
    }
}