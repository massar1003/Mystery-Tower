using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBasic : MonoBehaviour
{
    private Transform PlayerTransform;
    private Vector3 angle;              //x����]�i�㉺���_�j�݂̂ɐ��������������Ȃ�angle.x�ɂ̂ݒl������B
    private Vector3 primary_angle;      //�ŏ��̊p�x
    private float rotation_Y = 0;

    void Start()
    {
        PlayerTransform = transform.parent;     //���̊K�w�̃I�u�W�F�N�g�i�v���C���[�j��transform�𓾂�B

        angle = this.gameObject.transform.localEulerAngles;

        primary_angle = this.gameObject.transform.localEulerAngles;
    }


    void Update()
    {
        angle.x -= Input.GetAxis("Mouse Y");
        rotation_Y = Input.GetAxis("Mouse X");

        if (angle.x <= primary_angle.x - 90f)           //-90�x�ȉ��ɂȂ�����-90�x�ɂ���B
        {
            angle.x = primary_angle.x - 90f;
        }
        else if (angle.x >= primary_angle.x + 90f)      //90�x�ȏ�ɂȂ�����90�x�ɂ���B
        {
            angle.x = primary_angle.x + 90f;
        }

        this.gameObject.transform.localEulerAngles = angle; //angle�Ƃ͏����Ă�����̂́A���ۂɂ�angle.x�ɂ����l�������Ă��Ȃ��B
        PlayerTransform.transform.Rotate(0, rotation_Y, 0);
    }
}
