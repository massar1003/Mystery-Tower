using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stairs2_1 : MonoBehaviour
{
    //2階から1階へのシーン移動と1階のスタート位置の指定。
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            BeforeInGameStarter.playerPosition = new Vector3(-75, 31, -420);
            BeforeInGameStarter.playerRotation = new Vector3(0, 90, 0);
            SceneManager.LoadScene("ingame1");
        }
    }
}
