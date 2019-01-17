using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
    // public variables
    private bool simulationStarted;

    [Header("Player Variables")]
    public GameObject FadeOut;
    public bool playerMovement;
	
	public VRWalkController _vrWalkController;

    //UI VARIABLES
    [Header("UI Variables")]
	public List<GameObject> _gameUIs;
    public GameObject _welcomeUI;
    public GameObject _uiBg;
    public GameObject _nxtBtn;
    public GameObject _playerUI;
    private int _uiNum = 0;

    //STAGE 1 OBJECTS
    [Header("Stage 1 Variables")]
    public List<GameObject> _fireObject;

    [Header("Questions")]
    public List<GameObject> questionsUI = new List<GameObject>();


    void Start()
	{
		FadeOut.SetActive(false);
		playerMovement = false;
		simulationStarted = false;
        GameStart();
        //_uiBg.SetActive(true);
        //_nxtBtn.SetActive(true);

    }

	void Update()
	{
        //use update only for testing
        //Google VR SDK Does not support editor mode
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameUI();
        }

        if (simulationStarted)
		{
			StartCoroutine(GameFlow());
		}
	}

	public void GameStart()
	{
		
        _welcomeUI.SetActive(true);
        _uiBg.SetActive(true);
        _nxtBtn.SetActive(true);
        //_vrWalkController.playerMovement = true;
    }

	public void SceneMobileExit()
	{
		Application.Quit();
	}

	public void GameUI()
	{
        //Debug.Log(_gameUIs.Count);
        _welcomeUI.SetActive(false);
        _gameUIs[_uiNum].SetActive(false);
        

        Debug.Log(_gameUIs.Count);

        if (_uiNum + 1  < _gameUIs.Count)
        {
            Debug.Log(_uiNum + " List Number");
            _uiNum++;
            _gameUIs[_uiNum].SetActive(true);
        }

        else
        {
            Debug.Log("End");
            _uiNum = _gameUIs.Count;
            _uiBg.SetActive(false);
            _nxtBtn.SetActive(false);
            _playerUI.SetActive(true);
        }

        Debug.Log("UI NUMBER: " + _uiNum);

        if (_uiNum >= 5)
        {
            _vrWalkController.playerMovement = true;
            _uiNum = _gameUIs.Count;
            Debug.Log("WALK READY");
            simulationStarted = true;
        }

    }

    #region Questions


    public void CorrectAnswer()
    {

    }

    public void WrongAnswer()
    {

    }

    #endregion


    IEnumerator GameFlow()
	{
        //function UIs
        //Start fire
        //wait for 5 seconds
        yield return new WaitForSeconds(5);
        Debug.Log("Open Fire");
        _fireObject[0].SetActive(true);
        //open QA for level 1

            //UI level 2 start
            //start level 2 
            //find fire alarm and press
            //start sound alarm
            //UI level 2 finish
            //UI level 3 start
            //find fire extinguisher start
            //UI fire extinguisher end
            //UI level 3 end
            //UI level 4 start
            // go back to fire start
            //use fire extinguisher
            //UI level 4 end
            //congratulations
            //time
			yield return null;
	}



	
}
