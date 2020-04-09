using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    private GameObject mainCamera;//メインカメラ格納用
    private GameObject subCamera; //サブカメラ格納用

    // Start is called before the first frame update
    void Start()
    {
        //メインカメラとサブカメラをそれぜれ取得
        mainCamera = GameObject.Find("Main Camera");
        subCamera = GameObject.Find("Sub Camera");

        //サブカメラを非アクティブにする
        subCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //スペースキーが押されている間、サブカメラをアクティブにする
        if (Input.GetKey("space"))
        {
            //サブカメラをアクティブに設定
            mainCamera.SetActive(false);
            subCamera.SetActive(true);
        }
        else
        {
            //メインカメラをアクティブに設定
            subCamera.SetActive(false);
            mainCamera.SetActive(true);
        }
    }
}
