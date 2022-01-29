using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rader : MonoBehaviour
{
    //ターゲットの位置
    public Transform target;

    //トリガーが他のコライダーに触れているとき
    private void OnTriggerStay(Collider other)
    {
        //他のオブジェクトに"Player"Tagがあるとき
        if (other.CompareTag("Player"))
        {
            //触れたやつのrootの位置を見る
            transform.root.LookAt(target);
        }
    }
}
