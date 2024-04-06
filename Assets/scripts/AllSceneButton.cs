using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllSceneButton : MonoBehaviour
{
    //�{�^�����N���b�N����"�Q�[��"�ց@�����������̑O�ɏ����p�̃V�[��������B
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("setup");
    }

    //�{�^�����N���b�N����"�V�ѕ�����"��
    public void OnClickRuleButton()
    {
        SceneManager.LoadScene("howtoplay");
    }

    //�{�^�����N���b�N����"�ݒ�"��
    public void OnClickOptionButton()
    {
        SceneManager.LoadScene("option");
    }

    //�{�^�����N���b�N����"�g�p�A�Z�b�g"��
    public void OnClickAssetsButton()
    {
        SceneManager.LoadScene("assets");
    }

    //�{�^�����N���b�N����"�^�C�g��"��
    public void OnClickTitleButton()
    {
        SceneManager.LoadScene("title");
    }

    //�{�^�����N���b�N����"���j���["��
    public void OnClickMenuButton()
    {
        SceneManager.LoadScene("menu");
    }
}
