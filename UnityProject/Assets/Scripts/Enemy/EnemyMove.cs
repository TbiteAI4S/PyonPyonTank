using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    //ターゲット
    public GameObject target;
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;


    private NavMeshAgent agent;

    void Start()
    {
        //ナビメッシュを取得
        agent = GetComponent<NavMeshAgent>();
        //ターゲットを取得
        target = GameObject.FindGameObjectWithTag("Player");
        target1 = GameObject.Find("MovePoint1");
        target2 = GameObject.Find("MovePoint2");
        target3 = GameObject.Find("MovePoint3");
    }

    void Update()
    {
        //ターゲットの位置へ向かう
        agent.destination = target.transform.position;
    }
}
