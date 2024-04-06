using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stairs1_2 : MonoBehaviour
{
    //1階から2階へのシーン移動と2階のスタート位置の指定。
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
