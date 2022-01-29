﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour
{
    //被弾エフェクト
    public GameObject effectPrefab1;
    public GameObject effectPrefab2;
    //HP
    public int tankHP;
    public Text HPLabel;

    void Start()
    {
        HPLabel.text = "HP :" + tankHP;
    }

    private void OnTriggerEnter(Collider other)
    {
        // EnemyShellが当たったら
        if (other.gameObject.tag == "EnemyShell")
        {
            // HPを減らす
            tankHP -= 1;
            HPLabel.text = "HP :" + tankHP;

            // 砲弾破壊
            Destroy(other.gameObject);

            if (tankHP > 0)
            {
                GameObject effect1 = Instantiate(effectPrefab1, transform.position, Quaternion.identity);
                Destroy(effect1, 1.0f);
            }
            else
            {
                GameObject effect2 = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                Destroy(effect2, 1.0f);

                //プレーヤーを消す
                this.gameObject.SetActive(false);

                //1.5s後にGoToGameOver()を実行
                Invoke("GoToGameOver", 1.5f);
            }
        }
    }

    void GoToGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    //HPの回復
    public void AddHP(int amount)
    {
        tankHP += amount;

        //HPの最大値
        if (tankHP > 10)
        {
            tankHP = 10;
        }

        //UIを更新
        HPLabel.text = "HP :" + tankHP;
    }
}