using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //�Ō�̊K�i���オ��ƍ����V��ɐG���"gameclear"�V�[����
        if (collision.gameObject.name == "Player")
        {
            Cursor.visible = true;  //�}�E�X�J�[�\��ON
            SceneManager.LoadScene("gameclear");
        }
    }
}
