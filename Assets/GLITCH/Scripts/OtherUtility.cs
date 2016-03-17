using UnityEngine;

namespace GLITCH.Utilities
{
	public class OtherUtility {
		
		public static void SendMessageToAll(string message)
		{
			GameObject[] gos = Object.FindObjectsOfType<GameObject>();
			foreach (GameObject go in gos)
			{
				go.BroadcastMessage(message, SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}
