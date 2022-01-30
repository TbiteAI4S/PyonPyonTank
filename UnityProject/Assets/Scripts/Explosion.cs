using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    //ぶっ飛びのパーティクル
    [SerializeField] ParticleSystem particle;
    //ぶっ飛びの力
    [SerializeField] float force = 20;
    //ぶっ飛びの半径
    [SerializeField] float radius = 5;
    //ぶっ飛びの上方向の力
    [SerializeField] float upwards = 0;
    //発生源
    Vector3 position;


    public void Explode()
    {
        //パーティクルをつける
        particle.Play();
        //発生源はパーティクルの場所
        position = particle.transform.position;

        // 範囲内のRigidbodyにAddExplosionForce
        Collider[] hitColliders = Physics.OverlapSphere(position, radius);
        for (int i = 0; i < hitColliders.Length; i++)
        {
            var rb = hitColliders[i].GetComponent<Rigidbody>();
            if (rb)
            {
                rb.AddExplosionForce(force, position, radius, upwards, ForceMode.Impulse);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
