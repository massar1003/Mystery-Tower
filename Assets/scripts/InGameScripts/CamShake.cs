using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShake : MonoBehaviour
{
    private Transform CameraTransform;
    private float radius = 0.12f;    //���a
    private float phase = 0;        //�p�x
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
            if (count <= 20)    //phase��0�x~180�x�ōs��������i��/180 = 1�x�j�B
            {
                phase += Mathf.PI / 20; //1�t���[��9�x�ω�
            }
            else if (count <= 40)
            {
                phase -= Mathf.PI / 20; //1�t���[��9�x�ω�
            }
            else
            {
                count = 0;
            }
            count += 1;
        }

        //�J�����̈ʒu��ύX
        float yPos = radius * Mathf.Sin(phase);
        float xPos = radius * Mathf.Cos(phase);
        Vector3 pos = new Vector3(xPos, 0.8f + yPos, 0);
        CameraTransform.localPosition = pos;

        //Debug.Log(phase);
    }
}
