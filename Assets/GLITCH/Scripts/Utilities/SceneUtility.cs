using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace GLITCH.Utilities
{
	public class SceneUtility
	{
		private static List<GameObject> dontDestroy = new List<GameObject>();

		public static void LoadScene(Scene scene)
		{
			foreach (GameObject go in dontDestroy.ToArray())
			{
				Object.DontDestroyOnLoad(go);
			}
			SceneManager.LoadScene(scene.name);
			foreach (GameObject go in dontDestroy)
			{
				SceneManager.MoveGameObjectToScene(go, scene);
				go.SendMessage("StartUp");
			}
		}

		public static void LoadScene(int build)
		{
			foreach (GameObject go in dontDestroy.ToArray())
			{
				Object.DontDestroyOnLoad(go);
			}
			SceneManager.LoadScene(build);
			foreach (GameObject go in dontDestroy)
			{
				SceneManager.MoveGameObjectToScene(go, SceneManager.GetSceneAt(build));
				go.SendMessage("StartUp");
			}
		}

		public static void LoadScene(string name)
		{
			foreach (GameObject go in dontDestroy.ToArray())
			{
				Object.DontDestroyOnLoad(go);
			}
			SceneManager.LoadScene(name);
			foreach (GameObject go in dontDestroy)
			{
				SceneManager.MoveGameObjectToScene(go, SceneManager.GetSceneByName(name));
				go.SendMessage("StartUp");
			}
		}

		public static void DontDestroyOnLoad(GameObject go)
		{
			dontDestroy.Add(go);
		}
	}
}
