using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwticher : MonoBehaviour
{

	public GameObject FadeOut;
	public int sceneIndex;


	void OnTriggerEnter (Collider other) {

        //if (other.gameObject.tag == "Player") 
        //{

        //	StartCoroutine (SceneSwitch ());

        //}
        StartCoroutine(SceneSwitch());
    }

	IEnumerator SceneSwitch ()
    {

        FadeOut.SetActive(true);
        yield return new WaitForSeconds(2);

        //DontDestroyOnLoad(transform.gameObject);

        AsyncOperation loadingScene = SceneManager.LoadSceneAsync(sceneIndex);

        while (!loadingScene.isDone)
        {
            Debug.Log("Progress: " + loadingScene.progress); // incase for progress bars
            yield return null;
        }
    }

	public void SceneSwitchButton ()
    {
		StartCoroutine (SceneSwitch ());
	}
}
