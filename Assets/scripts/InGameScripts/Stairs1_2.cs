using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stairs1_2 : MonoBehaviour
{
    //1�K����2�K�ւ̃V�[���ړ���2�K�̃X�^�[�g�ʒu�̎w��B
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            BeforeInGameStarter.playerPosition = new Vector3(-445, 30, -305);
            BeforeInGameStarter.playerRotation = new Vector3(0, 0, 0);
            SceneManager.LoadScene("ingame2");
        }
    }
}
