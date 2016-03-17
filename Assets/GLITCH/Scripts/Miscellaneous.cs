using UnityEngine;

namespace GLITCH.Utilities
{
	public class Miscelanious : MonoBehaviour {
		
		public static void SendMessageToAll(string message)
		{
			GameObject[] gos = FindObjectsOfType<GameObject>();
			foreach (GameObject go in gos)
			{
				go.BroadcastMessage(message, SendMessageOptions.DontRequireReceiver);
			}
		}

	}
}
