using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stairs2_3 : MonoBehaviour
{
    //2�K����3�K�ւ̃V�[���ړ���3�K�̃X�^�[�g�ʒu�̎w��B
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            BeforeInGameStarter.playerPosition = new Vector3(-450, 30, -300);
            BeforeInGameStarter.playerRotation = new Vector3(0, 0, 0);
            SceneManager.LoadScene("ingame3");
        }
    }
}
