using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //�H��ɐG����"gameover"�V�[����
        if (collision.gameObject.name == "Player")
        {
            Cursor.visible = true;  //�}�E�X�J�[�\��ON
            SceneManager.LoadScene("gameover");
        }
    }
}
