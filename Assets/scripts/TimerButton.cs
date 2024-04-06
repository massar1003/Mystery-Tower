using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerButton : MonoBehaviour
{
    [SerializeField] public GameObject timer_ob_ON;       //�e�L�X�g�i"���݂�ON"�j������
    [SerializeField] public GameObject timer_ob_OFF;      //�e�L�X�g�i"���݂�OFF"�j������
    public static int timer_flag = 0;    //�^�C�}�[�\����ON/OFF�t���O

    void Update()
    {
        //"menu"�V�[������"option"�V�[���֖߂��Ă����ꍇ�ł��ݒ肪���������ꂽ�悤�ȕ\���ɂȂ�Ȃ��悤�ɂ���B
        if (timer_flag == 1)
        {
            timer_ob_ON.SetActive(true);      //"���݂�ON"���A�N�e�B�u��
            timer_ob_OFF.SetActive(false);    //"���݂�OFF"���A�N�e�B�u��
        }
        else
        {
            timer_ob_ON.SetActive(false);     //"���݂�ON"���A�N�e�B�u��
            timer_ob_OFF.SetActive(true);     //"���݂�OFF"���A�N�e�B�u��
        }
    }

    //�{�^�����N���b�N���ă^�C�}�[��"ON"��
    public void OnClickTimerONButton()
    {
        timer_ob_ON.SetActive(true);      //"���݂�ON"���A�N�e�B�u��
        timer_ob_OFF.SetActive(false);    //"���݂�OFF"���A�N�e�B�u��
        timer_flag = 1; //ON�̏ꍇ��1
    }

    //�{�^�����N���b�N���ă^�C�}�[��"OFF"��
    public void OnClickTimerOFFButton()
    {
        timer_ob_ON.SetActive(false);     //"���݂�ON"���A�N�e�B�u��
        timer_ob_OFF.SetActive(true);     //"���݂�OFF"���A�N�e�B�u��
        timer_flag = 0; //OFF�̏ꍇ��0
    }
}
