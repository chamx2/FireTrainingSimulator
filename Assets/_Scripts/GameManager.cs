using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{

    private static GameManager instance;

    public static GameManager Instance { get { return instance; } }

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
    public GameObject trialOneEndUI;
    //STAGE 1 OBJECTS


    [Header("Questions")]
    public List<GameObject> questionsUI = new List<GameObject>();

    [Header("Triggers")]
    public List<GameObject> triggerQuestions;

    [Header("Audio")]
    public AudioSource fireAlarm;

    [Header("Player Controls")]
    public GameObject tempParent;
    public Transform guide;
    public GameObject currentItem;

    [Header("Effects")]
    public List<GameObject> explosionEffects;
    public List<GameObject> fireParticles;
    public GameObject smokeEffect;
    public GameObject sparkEffect;


    void Awake()
    {
        instance = this;
    }

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

  //      if (simulationStarted)
		//{
		//	StartCoroutine(GameFlow());
		//}
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

    public void ReturnToTrialSelection()
    {
        StartCoroutine(SceneSwitcher());
    }

    IEnumerator SceneSwitcher()
    {
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(3);

        //DontDestroyOnLoad(transform.gameObject);

        AsyncOperation loadingScene = SceneManager.LoadSceneAsync(1);

        while (!loadingScene.isDone)
        {
            Debug.Log("Progress: " + loadingScene.progress); // incase for progress bars
            yield return null;
        }

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
            EnablePlayerWalk();
            _uiNum = _gameUIs.Count;
            simulationStarted = true;
        }

    }

    #region WalkController

    public void EnablePlayerWalk()
    {
        Debug.Log("Enable Walking");
        _vrWalkController.playerMovement = true;
        _vrWalkController._triggerEnter = false;
    }

    public void DisablePlayerWalk()
    {
        Debug.Log("Disable Walking");
        _vrWalkController.playerMovement = false;

    }



    #endregion

    #region Questions


    public void CorrectAnswer()
    {

    }

    public void WrongAnswer()
    {

    }

    #endregion

    #region Trial Effect Controller

    public void SmokeEffect()
    {
        smokeEffect.SetActive(true);
    }

    public void ActivateAlarm()
    {
        fireAlarm.Play();
    }

    public void ActivateExplosions()
    {
        for (int i = 0; i <= explosionEffects.Count; i++)
        {
            explosionEffects[i].SetActive(true);
        }
    }

    public void ActivateFireParticles()
    {
        for (int x = 0; x <= fireParticles.Count; x++)
        {
            fireParticles[x].SetActive(true);
        }
    }

    public GameObject SparkEffectGameObject()
    {
        return sparkEffect;
    }

    public GameObject SmokeEffectGameObject()
    {
        return smokeEffect;
    }

    public void TrialOneActivate()
    {


        for(int i=0; i<=explosionEffects.Count; i++)
        {
            explosionEffects[i].SetActive(true);
        }

        for(int x=0; x<=fireParticles.Count; x++)
        {
            fireParticles[x].SetActive(true);
        }
    }

    public void TrialOneEnd()
    {
        StartCoroutine(TrialOneEndFlow());
    }

    IEnumerator TrialOneEndFlow()
    {
        ActivateAlarm();
        yield return new WaitForSeconds(2);

        DisablePlayerWalk();
        trialOneEndUI.SetActive(true);


    }

    
    #endregion

    #region Player controls
    public void clickObject()
    {
        Debug.Log("Carrying the object");
        currentItem.GetComponent<Rigidbody>().useGravity = false;
        currentItem.GetComponent<Rigidbody>().isKinematic = true;
        currentItem.transform.position = guide.transform.position;
        //items.transform.rotation = guide.transform.rotation;
        currentItem.transform.parent = tempParent.transform;
    }

    public void letGoObject()
    {
        Debug.Log("Object released!");
        currentItem.GetComponent<Rigidbody>().useGravity = true;
        currentItem.GetComponent<Rigidbody>().isKinematic = false;
        currentItem.transform.parent = null;
        //items.transform.rotation = guide.transform.rotation;
        currentItem.transform.position = guide.transform.position;
    }
    #endregion

    #region Data Reference
    public void SetCurrentTrashItem(GameObject tempItem)
    {
        currentItem = tempItem;
    }

    public Transform GetGuide()
    {
        return guide;
    }

    public GameObject GetTempParent()
    {
        return tempParent;
    }

    public GameObject GetCurrentTrashItem()
    {
        return currentItem;
    }

    #endregion




 //   IEnumerator GameFlow()
	//{
 //       //function UIs
 //       //Start fire
 //       //wait for 5 seconds
 //       yield return new WaitForSeconds(3);
 //       //Debug.Log("Game Flow Started");
 //       //_fireObject[0].SetActive(true);


 //       //open QA for level 1
 //       if (_vrWalkController._triggerEnter)
 //       {
 //           //    Debug.Log("UI Level 2 Start");
 //           DisablePlayerWalk();
 //       }

 //       yield return new WaitForEndOfFrame();
 //       //UI level 2 start
 //       //start level 2 
 //       //find fire alarm and press
 //       //start sound alarm
 //       //UI level 2 finish
 //       //UI level 3 start
 //       //find fire extinguisher start
 //       //UI fire extinguisher end
 //       //UI level 3 end
 //       //UI level 4 start
 //       // go back to fire start
 //       //use fire extinguisher
 //       //UI level 4 end
 //       //congratulations
 //       //time
 //       yield return null;
	//}



	
}
