using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCounter : MonoBehaviour
{
    public static string ItemNum;

    public void Update()
    {
        //����̃A�C�e���擾����count�ɕۑ��B
        int count = 11 - GameObject.FindGameObjectsWithTag("Item").Length;
        //count��string�^�ɕϊ�����ItemNum�ɕۑ��B
        ItemNum = count.ToString();
    }
}
