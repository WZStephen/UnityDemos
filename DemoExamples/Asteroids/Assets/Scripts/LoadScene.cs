using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadScene : MonoBehaviour
{
	public string scenename;

	public void LoadSceneByName()
	{
		SceneManager.LoadScene(scenename);
	}
}
