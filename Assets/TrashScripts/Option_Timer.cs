using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option_Timer : MonoBehaviour
{    
    [SerializeField] public GameObject ob_ON;       //�e�L�X�g�i"���݂�ON"�j������
    [SerializeField] public GameObject ob_OFF;      //�e�L�X�g�i"���݂�OFF"�j������

    public bool ft_ON;     //"���݂�ON"�̐^�U����
    public bool ft_OFF;    //"���݂�OFF"�̐^�U����

    public static int flag; //0�Ȃ�OFF�A1�Ȃ�ON

    public static int ON_OFF()
    {
        return flag;
    }

    void Update()
    {
        ft_ON = ob_ON.activeSelf;       //�A�N�e�B�u���ǂ������肵ft_ON�ɕۑ�
        ft_OFF = ob_OFF.activeSelf;     //�A�N�e�B�u���ǂ������肵ft_OFF�ɕۑ�

        if(ft_ON == true)
        {
            flag = 1;
        }else if(ft_OFF == true)
        {
            flag = 0;
        }
    }
}
