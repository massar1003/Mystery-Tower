using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScripts : MonoBehaviour
{

	//��������
	private float totalTime;
	//�������ԁi���j
	[SerializeField]
	private int minute;
	//�������ԁi�b�j
	[SerializeField]
	private float seconds;
	//�O�̕b��
	private float oldSeconds;
	private Text timerText;
	public static string result;

	//�c�莞�Ԃ�string�^�œn���B
	public static string gettotal()
	{
		return result;
	}

	void Start()
	{
		//�b�Ōv�Z����B�i�\���͕��A�b�̂܂܁j
		totalTime = minute * 60 + seconds;
		oldSeconds = 0f;
		timerText = GetComponent<Text>();
	}

	void Update()
	{
		//�������Ԃ��v���B
		totalTime = minute * 60 + seconds;
		totalTime -= Time.deltaTime;

		//�Đݒ�
		minute = (int)totalTime / 60;
		seconds = totalTime - minute * 60;

		//�e�L�X�g�Ɏ��Ԃ�\������B
		if ((int)seconds != (int)oldSeconds)
		{
			timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
		}
		oldSeconds = seconds;
		//�������Ԉȉ��Ȃ�"�Q�[���I�[�o�["�ցB
		if (totalTime <= 0f)
		{
			SceneManager.LoadScene("1�Q�[���I�[�o�[");
		}

		//���݂̎c�莞�Ԃ�string�^�ŕۑ��B
		result = timerText.text;
	}
}