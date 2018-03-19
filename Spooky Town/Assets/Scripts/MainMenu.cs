using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public GameObject StartButton;
	public GameObject ExitButton;

	public void StartOnUp(string levle)
	{
		levle = "Spoopy_Town";
		SceneManager.LoadScene(levle,LoadSceneMode.Single);
	}

	public void ExitOnUp( ){
		Application.Quit ();

	}
}
