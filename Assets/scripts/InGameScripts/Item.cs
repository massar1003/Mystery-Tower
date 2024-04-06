using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public AudioClip se;
    public int ghostNumber;

    void OnCollisionEnter(Collision collision)
    {
        //プレイヤーが触れるとオブジェクトは消えて音が鳴る。
        if (collision.gameObject.name == "Player")
        {
            AudioSource.PlayClipAtPoint(se, Camera.main.transform.position);
            BeforeInGameStarter.items[ghostNumber] = 0;     //対象のゴーストが消えたという情報を残す
            Destroy(gameObject);
        }
    }
}
