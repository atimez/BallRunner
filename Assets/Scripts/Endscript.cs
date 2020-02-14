using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endscript : MonoBehaviour
{
	public void RestartGame()
	{
		SceneManager.LoadScene("MainScene");
	}

	public void ExitGame()
	{
		Debug.Log("You pressed exit button!");
		Application.Quit();
	}
}
