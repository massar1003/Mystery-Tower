using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScripts : MonoBehaviour
{

	//制限時間
	private float totalTime;
	//制限時間（分）
	[SerializeField]
	private int minute;
	//制限時間（秒）
	[SerializeField]
	private float seconds;
	//前の秒数
	private float oldSeconds;
	private Text timerText;
	public static string result;

	//残り時間をstring型で渡す。
	public static string gettotal()
	{
		return result;
	}

	void Start()
	{
		//秒で計算する。（表示は分、秒のまま）
		totalTime = minute * 60 + seconds;
		oldSeconds = 0f;
		timerText = GetComponent<Text>();
	}

	void Update()
	{
		//制限時間を計測。
		totalTime = minute * 60 + seconds;
		totalTime -= Time.deltaTime;

		//再設定
		minute = (int)totalTime / 60;
		seconds = totalTime - minute * 60;

		//テキストに時間を表示する。
		if ((int)seconds != (int)oldSeconds)
		{
			timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
		}
		oldSeconds = seconds;
		//制限時間以下なら"ゲームオーバー"へ。
		if (totalTime <= 0f)
		{
			SceneManager.LoadScene("1ゲームオーバー");
		}

		//現在の残り時間をstring型で保存。
		result = timerText.text;
	}
}