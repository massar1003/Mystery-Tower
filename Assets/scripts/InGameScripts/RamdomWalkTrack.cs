using UnityEngine;
using UnityEngine.AI;

public class RamdomWalkTrack : MonoBehaviour
{
    private float wanderRadius = 100;
    private float wanderTimer = 2;
    private float fixedTimer = 0;
    private NavMeshAgent agent;
    private Vector3 direction;

    public float range = 100;
    private Transform playerTransform;

    void Start()
    {
        //���g��NavMeshAgent�𓾂�B
        agent = GetComponent<NavMeshAgent>();
        //Player��transform���擾�B
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        //enemy�̈ʒu�𒆐S�Ƃ����A���awanderRadius�̋��̒����烉���_���ɖړI�n�����������B
        //���[���h���W(0,0,0)�𒆐S�Ƃ������a1�̋��̒����烉���_���ɏo�����W * ���� + �ʒu
        //�ŏ��̖ړI�n�𐶐�����B
        direction = Random.insideUnitSphere * wanderRadius + transform.position;
        //�ŏ��̖ړI�n��ݒ肷��B
        agent.SetDestination(direction);
    }

    void Update()
    {
        //wanderTimer�ɒB����܂ő�������J��Ԃ��B
        fixedTimer += Time.deltaTime;

        //��莞�Ԃ��ƂɃ����_���ɐV�����ꏊ��ړI�n�Ƃ���B
        if (fixedTimer >= wanderTimer)
        {
            direction = Random.insideUnitSphere * wanderRadius + transform.position;
            agent.SetDestination(direction);
            fixedTimer = 0;
        }

        //�͈͓��ɓ�������ړI�n��Player�ɂ���B�i����ȊO��randomWalk.cs�������Ă����B�j
        if (Vector3.Distance(transform.position, playerTransform.position) <= range)
        {
            agent.SetDestination(playerTransform.position);
        }
        //Debug.Log(direction);
    }
}