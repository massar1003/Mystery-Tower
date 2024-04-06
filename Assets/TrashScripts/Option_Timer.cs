using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option_Timer : MonoBehaviour
{    
    [SerializeField] public GameObject ob_ON;       //テキスト（"現在はON"）を入れる
    [SerializeField] public GameObject ob_OFF;      //テキスト（"現在はOFF"）を入れる

    public bool ft_ON;     //"現在はON"の真偽判定
    public bool ft_OFF;    //"現在はOFF"の真偽判定

    public static int flag; //0ならOFF、1ならON

    public static int ON_OFF()
    {
        return flag;
    }

    void Update()
    {
        ft_ON = ob_ON.activeSelf;       //アクティブかどうか判定しft_ONに保存
        ft_OFF = ob_OFF.activeSelf;     //アクティブかどうか判定しft_OFFに保存

        if(ft_ON == true)
        {
            flag = 1;
        }else if(ft_OFF == true)
        {
            flag = 0;
        }
    }
}
