using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ResultNum : MonoBehaviour
{
    public Text ghostnum;

    //�A�C�e���擾�����v�Z���āA�e�L�X�g�ɕ\��������B
    void Start()
    {
        ghostnum.text = (BeforeInGameStarter.items.Length - BeforeInGameStarter.items.Sum()).ToString();
    }
}
