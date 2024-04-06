using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTime : MonoBehaviour
{
    public Text resultTimerText;
    private int minute;
    private float second;

    //時間を得て、テキストに表示させる。
    void Start()
    {
        float time = BeforeInGameStarter.nowTime;
        minute = (int)time / 60;
        second = time - minute * 60;
        resultTimerText.text = minute.ToString("00") + ":" + ((int)second).ToString("00");
    }
}
