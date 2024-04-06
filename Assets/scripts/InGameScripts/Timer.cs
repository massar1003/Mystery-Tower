using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
	void Update()
	{
		//Œ»İ‚ÌŒo‰ßŠÔ(•b)‚ğ•Û‘¶B
		BeforeInGameStarter.nowTime += Time.deltaTime;
	}
}