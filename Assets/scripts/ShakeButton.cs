using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeButton : MonoBehaviour
{
    [SerializeField] public GameObject shake_ob_ON;       //テキスト（"現在はON"）を入れる
    [SerializeField] public GameObject shake_ob_OFF;      //テキスト（"現在はOFF"）を入れる
    public static int shake_flag = 0;    //揺れのON/OFFフラグ

    void Start()
    {
        //"menu"シーンから"option"シーンへ戻ってきた場合でも設定が初期化されたような表示にならないようにする。
        if(shake_flag == 1)
        {
            shake_ob_ON.SetActive(true);      //"現在はON"をアクティブへ
            shake_ob_OFF.SetActive(false);    //"現在はOFF"を非アクティブへ
        }
        else
        {
            shake_ob_ON.SetActive(false);     //"現在はON"を非アクティブへ
            shake_ob_OFF.SetActive(true);     //"現在はOFF"をアクティブへ
        }
    }

    //ボタンをクリックしてタイマーを"ON"へ
    public void OnClickShakeONButton()
    {
        shake_ob_ON.SetActive(true);
        shake_ob_OFF.SetActive(false);
        shake_flag = 1; //ONの場合は1
    }

    //ボタンをクリックしてタイマーを"OFF"へ
    public void OnClickShakeOFFButton()
    {
        shake_ob_ON.SetActive(false);
        shake_ob_OFF.SetActive(true);
        shake_flag = 0; //OFFの場合は0
    }
}