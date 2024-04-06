using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ResultNum : MonoBehaviour
{
    public Text ghostnum;

    //アイテム取得数を計算して、テキストに表示させる。
    void Start()
    {
        ghostnum.text = (BeforeInGameStarter.items.Length - BeforeInGameStarter.items.Sum()).ToString();
    }
}
