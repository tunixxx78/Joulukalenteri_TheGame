using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolingAnimals : MonoBehaviour
{
    public Transform[] wayPoints;
    [SerializeField] NavMeshAgent animalAgent;
    [SerializeField] Animator animalAnimator;
    
    int nextWaypoint;

    private void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        animalAgent.destination = wayPoints[nextWaypoint].position;
        animalAgent.isStopped = false;

        if(animalAgent.remainingDistance <= animalAgent.stoppingDistance && !this.animalAgent.pathPending)
        {
            nextWaypoint = (nextWaypoint + 1) % wayPoints.Length;
        }
    }

}
