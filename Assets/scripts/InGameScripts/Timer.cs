using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
	void Update()
	{
		//現在の経過時間(秒)を保存。
		BeforeInGameStarter.nowTime += Time.deltaTime;
	}
}