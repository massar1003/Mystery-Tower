using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShake : MonoBehaviour
{
    private Transform CameraTransform;
    private float radius = 0.12f;    //半径
    private float phase = 0;        //角度
    private int count = 0;

    void Start()
    {
        CameraTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            if (count <= 20)    //phaseは0度~180度で行き来する（π/180 = 1度）。
            {
                phase += Mathf.PI / 20; //1フレーム9度変化
            }
            else if (count <= 40)
            {
                phase -= Mathf.PI / 20; //1フレーム9度変化
            }
            else
            {
                count = 0;
            }
            count += 1;
        }

        //カメラの位置を変更
        float yPos = radius * Mathf.Sin(phase);
        float xPos = radius * Mathf.Cos(phase);
        Vector3 pos = new Vector3(xPos, 0.8f + yPos, 0);
        CameraTransform.localPosition = pos;

        //Debug.Log(phase);
    }
}
