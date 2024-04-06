using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCounter : MonoBehaviour
{
    public static string ItemNum;

    public void Update()
    {
        //現状のアイテム取得数をcountに保存。
        int count = 11 - GameObject.FindGameObjectsWithTag("Item").Length;
        //countをstring型に変換してItemNumに保存。
        ItemNum = count.ToString();
    }
}
