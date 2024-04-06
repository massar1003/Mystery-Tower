using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeButton : MonoBehaviour
{
    [SerializeField] public GameObject shake_ob_ON;       //�e�L�X�g�i"���݂�ON"�j������
    [SerializeField] public GameObject shake_ob_OFF;      //�e�L�X�g�i"���݂�OFF"�j������
    public static int shake_flag = 0;    //�h���ON/OFF�t���O

    void Start()
    {
        //"menu"�V�[������"option"�V�[���֖߂��Ă����ꍇ�ł��ݒ肪���������ꂽ�悤�ȕ\���ɂȂ�Ȃ��悤�ɂ���B
        if(shake_flag == 1)
        {
            shake_ob_ON.SetActive(true);      //"���݂�ON"���A�N�e�B�u��
            shake_ob_OFF.SetActive(false);    //"���݂�OFF"���A�N�e�B�u��
        }
        else
        {
            shake_ob_ON.SetActive(false);     //"���݂�ON"���A�N�e�B�u��
            shake_ob_OFF.SetActive(true);     //"���݂�OFF"���A�N�e�B�u��
        }
    }

    //�{�^�����N���b�N���ă^�C�}�[��"ON"��
    public void OnClickShakeONButton()
    {
        shake_ob_ON.SetActive(true);
        shake_ob_OFF.SetActive(false);
        shake_flag = 1; //ON�̏ꍇ��1
    }

    //�{�^�����N���b�N���ă^�C�}�[��"OFF"��
    public void OnClickShakeOFFButton()
    {
        shake_ob_ON.SetActive(false);
        shake_ob_OFF.SetActive(true);
        shake_flag = 0; //OFF�̏ꍇ��0
    }
}