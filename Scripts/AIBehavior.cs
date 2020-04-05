using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBehavior : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject pl;
    private Transform player;
    public float EnemyDistanceRun = 10.0f;

    private void Start() { // Assignar player og player transform fyrir easy referencing
        pl = GameObject.Find("FPSController");
        player = pl.GetComponent<Transform>();
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update() {
        float distance = Vector3.Distance(transform.position, player.position); // Lengd á milli playerinum og objectinum

        // Hlaupa í burtu frá player
        if (distance < EnemyDistanceRun) { // Gerir það þannig að AI reynir alltaf að vera ákveðið langt í burtu
            Vector3 dirToPlayer = transform.position - player.position;

            Vector3 newPos = transform.position + dirToPlayer;

            agent.SetDestination(newPos);
        }
    }


}
