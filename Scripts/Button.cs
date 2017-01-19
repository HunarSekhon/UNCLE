using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

	public void NewGameBin(string newGameLevel)
	{
		SceneManager.LoadScene (newGameLevel);
	
	}
	public void Exit()
	{
		Application.Quit ();
	}

}
