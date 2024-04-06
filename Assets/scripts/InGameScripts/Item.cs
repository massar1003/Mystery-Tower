using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public AudioClip se;
    public int ghostNumber;

    void OnCollisionEnter(Collision collision)
    {
        //�v���C���[���G���ƃI�u�W�F�N�g�͏����ĉ�����B
        if (collision.gameObject.name == "Player")
        {
            AudioSource.PlayClipAtPoint(se, Camera.main.transform.position);
            BeforeInGameStarter.items[ghostNumber] = 0;     //�Ώۂ̃S�[�X�g���������Ƃ��������c��
            Destroy(gameObject);
        }
    }
}
