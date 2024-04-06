using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllSceneButton : MonoBehaviour
{
    //ボタンをクリックして"ゲーム"へ　※ただしその前に準備用のシーンが入る。
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("setup");
    }

    //ボタンをクリックして"遊び方説明"へ
    public void OnClickRuleButton()
    {
        SceneManager.LoadScene("howtoplay");
    }

    //ボタンをクリックして"設定"へ
    public void OnClickOptionButton()
    {
        SceneManager.LoadScene("option");
    }

    //ボタンをクリックして"使用アセット"へ
    public void OnClickAssetsButton()
    {
        SceneManager.LoadScene("assets");
    }

    //ボタンをクリックして"タイトル"へ
    public void OnClickTitleButton()
    {
        SceneManager.LoadScene("title");
    }

    //ボタンをクリックして"メニュー"へ
    public void OnClickMenuButton()
    {
        SceneManager.LoadScene("menu");
    }
}
