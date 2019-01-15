using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour {
// public variables
	public GameObject FadeOut;
	public GameObject mainMenu;
	public GameObject instructions;

	public int sceneIndex;

	void Start()
	{
		FadeOut.SetActive (false);
		mainMenu.SetActive (false);
		instructions.SetActive (true);

	}

	void Update()
	{
		//use update only for testing
		//Google VR SDK Does not support editor mode

		if(Input.GetKeyDown(KeyCode.Space))
		{
			StartCoroutine(SceneSwitcher());
		}

	}

	public void GameStart()
	{
		//SceneManager.LoadScene(1);
		StartCoroutine(SceneSwitcher());
		
	}

	public void SceneMobileExit()
	{
		Application.Quit();
	}

	public void OpenMenu () 
	{
		mainMenu.SetActive (true);
		instructions.SetActive (false);
	}


	IEnumerator SceneSwitcher()
	{
		FadeOut.SetActive (true);
		yield return new WaitForSeconds (3);

		//DontDestroyOnLoad(transform.gameObject);

		AsyncOperation loadingScene = SceneManager.LoadSceneAsync (sceneIndex);

		while(!loadingScene.isDone)
		{
			Debug.Log("Progress: " + loadingScene.progress); // incase for progress bars
			yield return null;
		}

	}
}
