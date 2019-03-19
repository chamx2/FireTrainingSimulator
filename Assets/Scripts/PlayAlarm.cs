using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAlarm : MonoBehaviour
{
    public AudioSource _fireAlarm;
    public GameObject _title;
    public GameObject _notification;
    //public GameObject _fireEffect;
    //public GameObject _smokeEffect;
    //public GameObject _sparkEffect;

    private void OnMouseOver()
    {
        _notification.SetActive(true);
        PlayFireAlarm();

    }

    private void OnMouseDown()
    {
        PlayFireAlarm();
    }

    private void OnMouseExit()
    {
        _title.SetActive(false);
    }

    public void PlayFireAlarm()
    {
        //Debug.Log("Fire!!");
        //_fireAlarm.Play();
        GameManager.Instance.TrialOneEnd();
    }
  
}
