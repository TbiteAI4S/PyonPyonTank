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
    }

    void Update()
    {
        //ターゲットの位置へ向かう
        agent.destination = target.transform.position;
    }
}
