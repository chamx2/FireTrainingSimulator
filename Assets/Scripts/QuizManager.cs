using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{

    public GameObject questionObject;

    public string question;

    public List<GameObject> answers = new List<GameObject>();


    public Text feedbackAnswer;

    public List<string> feedbackText = new List<string>();


    public void CorrectAnswer()
    {
        feedbackAnswer.text = feedbackText[0];
        Debug.Log("CORRECT!");
        Destroy(this.gameObject, 2);
    }

    public void WrongAnswer()
    {
        feedbackAnswer.text = feedbackText[1];
        Debug.Log("WRONG!");
    }

  




}
