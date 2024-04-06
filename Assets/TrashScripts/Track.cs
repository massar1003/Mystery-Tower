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
        //���g��NavMeshAgent�𓾂�B
        agent = GetComponent<NavMeshAgent>();
        //"Player"�Ƃ����^�O���������I�u�W�F�N�g��ړI�n�ɂ���B
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        //�͈͓��ɓ�������ړI�n��"Player"�^�O���������I�u�W�F�N�g�ɂ���B�i����ȊO��randomWalk.cs�������Ă����B�j
        if (Vector3.Distance(transform.position, target.position) <= range)
        {
            agent.SetDestination(target.position);
        }
    }
}