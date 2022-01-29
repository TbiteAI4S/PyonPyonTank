using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmaraController : MonoBehaviour
{
    public Camera mainCamera;
    public Camera subCamera;
    //mainカメラを使うかどうか
    private bool mainCameraON = true;
    //照準UI
    public GameObject aimImage;

    void Start()
    {
        mainCamera.enabled = true;
        subCamera.enabled = false;

        //mainでは照準UIをオフにする
        aimImage.SetActive(false);
    }

    void Update()
    {
        // 視点を近づける
        if (Input.GetKeyDown(KeyCode.LeftShift) && mainCameraON == true)
        {
            mainCamera.enabled = false;
            subCamera.enabled = true;

            mainCameraON = false;

            //照準UIオン
            aimImage.SetActive(true);

        } // 視点を元に戻す
        else if (Input.GetKeyDown(KeyCode.LeftShift) && mainCameraON == false)
        {
            mainCamera.enabled = true;
            subCamera.enabled = false;

            mainCameraON = true;

            //照準UIオフ
            aimImage.SetActive(false);
        }
    }
}
