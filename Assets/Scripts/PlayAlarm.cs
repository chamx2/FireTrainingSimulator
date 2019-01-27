using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAlarm : MonoBehaviour
{
    public AudioSource _fireAlarm;
    public GameObject _title;
    public GameObject _notification;
    public GameObject _fireEffect;
    public GameObject _smokeEffect;
    public GameObject _sparkEffect;

    private void OnMouseOver()
    {
        _title.SetActive(true);

        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("Alarm Pressed");
        //    _fireAlarm.Play();
        //    Destroy(_smokeEffect);
        //    Destroy(_sparkEffect);
        //    _notification.SetActive(true);
        //    _fireEffect.SetActive(true);
        //}

    }

    private void OnMouseExit()
    {
        _title.SetActive(false);
    }

    public void PlayAlarmEffect()
    {
        Debug.Log("FireAlarmEffect");
        _fireAlarm.Play();
    }

  
}
