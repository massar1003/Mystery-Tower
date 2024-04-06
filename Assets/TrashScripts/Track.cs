using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Track : MonoBehaviour
{
    public float range = 1000f;
    private Transform target;

    private NavMeshAgent agent;

    private void Start()
    {
        //自身のNavMeshAgentを得る。
        agent = GetComponent<NavMeshAgent>();
        //"Player"というタグを持ったオブジェクトを目的地にする。
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        //範囲内に入ったら目的地を"Player"タグを持ったオブジェクトにする。（それ以外はrandomWalk.csが働いてくれる。）
        if (Vector3.Distance(transform.position, target.position) <= range)
        {
            agent.SetDestination(target.position);
        }
    }
}