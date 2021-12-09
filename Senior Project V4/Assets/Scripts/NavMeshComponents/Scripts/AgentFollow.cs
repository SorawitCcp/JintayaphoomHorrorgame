using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class AgentFollow : MonoBehaviour
{
    public Transform position;
    NavMeshAgent agent;
    public ThirdPersonCharacter character;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(position.position);
        agent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(position.position);

        if (agent.remainingDistance > agent.stoppingDistance)
        {
            animator.SetInteger("AnanMove", 1);
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            animator.SetInteger("AnanMove", 0);
            character.Move(Vector3.zero, false, false);
        }
    }
}
