using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBasic : MonoBehaviour
{
    private Transform PlayerTransform;
    private Vector3 angle;              //x軸回転（上下視点）のみに制限をかけたいならangle.xにのみ値を入れる。
    private Vector3 primary_angle;      //最初の角度
    private float rotation_Y = 0;

    void Start()
    {
        PlayerTransform = transform.parent;     //一つ上の階層のオブジェクト（プレイヤー）のtransformを得る。

        angle = this.gameObject.transform.localEulerAngles;

        primary_angle = this.gameObject.transform.localEulerAngles;
    }


    void Update()
    {
        angle.x -= Input.GetAxis("Mouse Y");
        rotation_Y = Input.GetAxis("Mouse X");

        if (angle.x <= primary_angle.x - 90f)           //-90度以下になったら-90度にする。
        {
            angle.x = primary_angle.x - 90f;
        }
        else if (angle.x >= primary_angle.x + 90f)      //90度以上になったら90度にする。
        {
            angle.x = primary_angle.x + 90f;
        }

        this.gameObject.transform.localEulerAngles = angle; //angleとは書いているものの、実際にはangle.xにしか値が入っていない。
        PlayerTransform.transform.Rotate(0, rotation_Y, 0);
    }
}
