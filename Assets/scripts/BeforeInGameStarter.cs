using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeforeInGameStarter : MonoBehaviour
{
    //�A�C�e���̐錾
    public static int[] items;

    //�v���C���[�̈ʒu�ƌ����̐錾
    public static Vector3 playerPosition;
    public static Vector3 playerRotation;

    //�^�C�}�[�̐錾
    public static float nowTime;

    void Start()
    {
        items = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        playerPosition = new Vector3(-440, 31, 375);
        playerRotation = new Vector3(0, 0, 0);
        nowTime = 0;
        Cursor.visible = false;     //�}�E�X�J�[�\�����\��
        SceneManager.LoadScene("ingame1");
    }
}
