using UnityEngine;

namespace GLITCH.Utilities
{
	public class ButtonUtility : MonoBehaviour {

		public static void StartGame()
		{
			Time.timeScale = 1.0f;
			Time.fixedDeltaTime = 0.02f;
			Miscelanious.SendMessageToAll("StartGame");
		}

		public static void PauseGame()
		{
			Time.timeScale = 0;
			Time.fixedDeltaTime = 0.0f;
			Miscelanious.SendMessageToAll("PauseGame");
		}

		public static void ResumeGame()
		{
			Time.timeScale = 1.0f;
			Time.fixedDeltaTime = 0.02f;
			Miscelanious.SendMessageToAll("ResumeGame");
		}

		public static void ChangeTimeSpeed(float newSpeed)
		{
			Time.timeScale = newSpeed;
			Time.fixedDeltaTime = 0.02f;
		}
	}
}
