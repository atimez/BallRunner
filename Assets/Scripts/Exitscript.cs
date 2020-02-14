using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exitscript : MonoBehaviour
{
	public void exitgame()
	{
		Debug.Log("You Pressed exit button");
		Application.Quit();
	}
}
