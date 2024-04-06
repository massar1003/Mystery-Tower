using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //幽霊に触れると"gameover"シーンへ
        if (collision.gameObject.name == "Player")
        {
            Cursor.visible = true;  //マウスカーソルON
            SceneManager.LoadScene("gameover");
        }
    }
}
