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
        //���g��Rigidbody�𓾂�B
        rb = GetComponent<Rigidbody>();
        //�Q�[�����n�߂����̈ʒu��ݒ肷��B
        player.transform.position = BeforeInGameStarter.playerPosition;
        player.transform.localEulerAngles = BeforeInGameStarter.playerRotation;
    }

    void Update()
    {
        //�������Ȃ���Ύ~�܂�B
        rb.velocity = new Vector3(0, 0, 0);
        
        //"A"�ō��ֈړ�
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = transform.right * -speed;
        }
        
        //"D"�ŉE�Ɉړ�
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = transform.right * speed;
        }
       
        //"W"�őO�ֈړ�
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.forward * speed;
        }
        
        //"S"�Ō��ֈړ�
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = transform.forward * -speed;
        }

        //"R"�ł����Ƀ��g���C
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("setup");
        }

        //"Escape"�Ń��j���[�V�[����
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.visible = true;
            SceneManager.LoadScene("menu");
        }
    }

}
