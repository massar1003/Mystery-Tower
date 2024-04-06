using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameStarter : MonoBehaviour
{
    private GameObject timer_ob_text;
    private GameObject camera_ob_shake;
    private GameObject camera_ob_noShake;
    private int timer_flag;
    private int shake_flag;

    // Start is called before the first frame update
    void Start()
    {
        timer_ob_text = GameObject.Find("Canvas/Timer");
        camera_ob_shake = GameObject.Find("Player/CameraShake");
        camera_ob_noShake = GameObject.Find("Player/CameraNoShake");
        timer_flag = TimerButton.timer_flag;    //0�Ȃ�OFF�A1�Ȃ�ON;
        shake_flag = ShakeButton.shake_flag;    //0�Ȃ�OFF�A1�Ȃ�ON;

        //�^�C�}�[�̕\���A��\��
        if (timer_flag == 1)
        {
            timer_ob_text.SetActive(true);
        }
        else
        {
            timer_ob_text.SetActive(false);
        }

        //�h���ON/OFF�i�J�����̐؂�ւ��j
        if (shake_flag == 1)
        {
            camera_ob_noShake.SetActive(false);
            camera_ob_shake.SetActive(true);
        }
        else
        {
            camera_ob_noShake.SetActive(true);
            camera_ob_shake.SetActive(false);
        }

        Debug.Log("timer_flag:" + timer_flag);
        Debug.Log("shake_flag:" + shake_flag);

        //�擾�ς݂̃I�u�W�F�N�g�̍폜
        GameObject item0 = GameObject.Find("1�K/Item0");
        GameObject item1 = GameObject.Find("1�K/Item1");
        GameObject item2 = GameObject.Find("1�K/Item2");
        GameObject item3 = GameObject.Find("1�K/Item3");
        GameObject item4 = GameObject.Find("2�K/Item4");
        GameObject item5 = GameObject.Find("2�K/Item5");
        GameObject item6 = GameObject.Find("2�K/Item6");
        GameObject item7 = GameObject.Find("3�K/Item7");
        GameObject item8 = GameObject.Find("3�K/Item8");
        GameObject item9 = GameObject.Find("3�K/Item9");
        GameObject item10 = GameObject.Find("3�K/Item10");

        if (item0 != null && BeforeInGameStarter.items[0] == 0)
        {
            Destroy(item0);
        }
        if (item1 != null && BeforeInGameStarter.items[1] == 0)
        {
            Destroy(item1);
        }
        if (item2 != null && BeforeInGameStarter.items[2] == 0)
        {
            Destroy(item2);
        }
        if (item3 != null && BeforeInGameStarter.items[3] == 0)
        {
            Destroy(item3);
        }
        if (item4 != null && BeforeInGameStarter.items[4] == 0)
        {
            Destroy(item4);
        }
        if (item5 != null && BeforeInGameStarter.items[5] == 0)
        {
            Destroy(item5);
        }
        if (item6 != null && BeforeInGameStarter.items[6] == 0)
        {
            Destroy(item6);
        }
        if (item7 != null && BeforeInGameStarter.items[7] == 0)
        {
            Destroy(item7);
        }
        if (item8 != null && BeforeInGameStarter.items[8] == 0)
        {
            Destroy(item8);
        }
        if (item9 != null && BeforeInGameStarter.items[9] == 0)
        {
            Destroy(item9);
        }
        if (item10 != null && BeforeInGameStarter.items[10] == 0)
        {
            Destroy(item10);
        }
    }
}
