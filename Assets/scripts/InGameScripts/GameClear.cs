using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //最後の階段を上がると黒い天井に触れて"gameclear"シーンへ
        if (collision.gameObject.name == "Player")
        {
            Cursor.visible = true;  //マウスカーソルON
            SceneManager.LoadScene("gameclear");
        }
    }
}
