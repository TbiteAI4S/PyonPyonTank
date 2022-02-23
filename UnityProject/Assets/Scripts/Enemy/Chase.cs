using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    //ターゲット
    public GameObject target;
    private NavMeshAgent agent;

    void Start()
    {
        //ナビメッシュを取得
        agent = GetComponent<NavMeshAgent>();
        //ターゲットを取得
        target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        //ターゲットの位置へ向かう
        agent.destination = target.transform.position;
    }
}
