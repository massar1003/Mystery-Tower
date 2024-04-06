using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerButton : MonoBehaviour
{
    [SerializeField] public GameObject timer_ob_ON;       //テキスト（"現在はON"）を入れる
    [SerializeField] public GameObject timer_ob_OFF;      //テキスト（"現在はOFF"）を入れる
    public static int timer_flag = 0;    //タイマー表示のON/OFFフラグ

    void Update()
    {
        //"menu"シーンから"option"シーンへ戻ってきた場合でも設定が初期化されたような表示にならないようにする。
        if (timer_flag == 1)
        {
            timer_ob_ON.SetActive(true);      //"現在はON"をアクティブへ
            timer_ob_OFF.SetActive(false);    //"現在はOFF"を非アクティブへ
        }
        else
        {
            timer_ob_ON.SetActive(false);     //"現在はON"を非アクティブへ
            timer_ob_OFF.SetActive(true);     //"現在はOFF"をアクティブへ
        }
    }

    //ボタンをクリックしてタイマーを"ON"へ
    public void OnClickTimerONButton()
    {
        timer_ob_ON.SetActive(true);      //"現在はON"をアクティブへ
        timer_ob_OFF.SetActive(false);    //"現在はOFF"を非アクティブへ
        timer_flag = 1; //ONの場合は1
    }

    //ボタンをクリックしてタイマーを"OFF"へ
    public void OnClickTimerOFFButton()
    {
        timer_ob_ON.SetActive(false);     //"現在はON"を非アクティブへ
        timer_ob_OFF.SetActive(true);     //"現在はOFF"をアクティブへ
        timer_flag = 0; //OFFの場合は0
    }
}
