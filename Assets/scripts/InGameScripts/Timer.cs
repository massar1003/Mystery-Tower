using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
	void Update()
	{
		//���݂̌o�ߎ���(�b)��ۑ��B
		BeforeInGameStarter.nowTime += Time.deltaTime;
	}
}