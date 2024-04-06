using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeforeInGameStarter : MonoBehaviour
{
    //アイテムの宣言
    public static int[] items;

    //プレイヤーの位置と向きの宣言
    public static Vector3 playerPosition;
    public static Vector3 playerRotation;

    //タイマーの宣言
    public static float nowTime;

    void Start()
    {
        items = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        playerPosition = new Vector3(-440, 31, 375);
        playerRotation = new Vector3(0, 0, 0);
        nowTime = 0;
        Cursor.visible = false;     //マウスカーソルを非表示
        SceneManager.LoadScene("ingame1");
    }
}
