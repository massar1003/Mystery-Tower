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
        //���g��NavMeshAgent�𓾂�B
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        //�^�[�Q�b�g�i�v���C���[�j��ړI�n�Ƃ���B
        agent.destination = target.transform.position;
    }
}
