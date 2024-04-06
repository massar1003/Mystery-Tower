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
        //自身のNavMeshAgentを得る。
        agent = GetComponent<NavMeshAgent>();
        //Playerのtransformを取得。
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        //enemyの位置を中心とした、半径wanderRadiusの球の中からランダムに目的地が生成される。
        //ワールド座標(0,0,0)を中心とした半径1の球の中からランダムに出た座標 * 距離 + 位置
        //最初の目的地を生成する。
        direction = Random.insideUnitSphere * wanderRadius + transform.position;
        //最初の目的地を設定する。
        agent.SetDestination(direction);
    }

    void Update()
    {
        //wanderTimerに達するまで増えるを繰り返す。
        fixedTimer += Time.deltaTime;

        //一定時間ごとにランダムに新しい場所を目的地とする。
        if (fixedTimer >= wanderTimer)
        {
            direction = Random.insideUnitSphere * wanderRadius + transform.position;
            agent.SetDestination(direction);
            fixedTimer = 0;
        }

        //範囲内に入ったら目的地をPlayerにする。（それ以外はrandomWalk.csが働いてくれる。）
        if (Vector3.Distance(transform.position, playerTransform.position) <= range)
        {
            agent.SetDestination(playerTransform.position);
        }
        //Debug.Log(direction);
    }
}