using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Rigidbody rb;
    public float speed;

    void Start()
    {
        //自身のRigidbodyを得る。
        rb = GetComponent<Rigidbody>();
        //ゲームを始めた時の位置を設定する。
        player.transform.position = BeforeInGameStarter.playerPosition;
        player.transform.localEulerAngles = BeforeInGameStarter.playerRotation;
    }

    void Update()
    {
        //何もしなければ止まる。
        rb.velocity = new Vector3(0, 0, 0);
        
        //"A"で左へ移動
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = transform.right * -speed;
        }
        
        //"D"で右に移動
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = transform.right * speed;
        }
       
        //"W"で前へ移動
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.forward * speed;
        }
        
        //"S"で後ろへ移動
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = transform.forward * -speed;
        }

        //"R"ですぐにリトライ
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("setup");
        }

        //"Escape"でメニューシーンへ
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.visible = true;
            SceneManager.LoadScene("menu");
        }
    }

}
