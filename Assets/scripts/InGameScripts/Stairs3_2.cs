using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stairs3_2 : MonoBehaviour
{
    //3�K����2�K�ւ̃V�[���ړ���2�K�̃X�^�[�g�ʒu�̎w��B
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            BeforeInGameStarter.playerPosition = new Vector3(-50, 30, -420);
            BeforeInGameStarter.playerRotation = new Vector3(0, 90, 0);
            SceneManager.LoadScene("ingame2");
        }
    }
}
