using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour
{
    public Text nowTimerText;
    private int minute;
    private float second;

    //���Ԃ𓾂āA�e�L�X�g�ɕ\��������B
    void Update()
    {
        float time = BeforeInGameStarter.nowTime;
        minute = (int)time / 60;
        second = time - minute * 60;
        nowTimerText.text = minute.ToString("00") + ":" + ((int)second).ToString("00");
    }   
}