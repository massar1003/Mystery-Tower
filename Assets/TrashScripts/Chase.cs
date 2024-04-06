using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent agent;

    void Start()
    {
        //自身のNavMeshAgentを得る。
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        //ターゲット（プレイヤー）を目的地とする。
        agent.destination = target.transform.position;
    }
}
