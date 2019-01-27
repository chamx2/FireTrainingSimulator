using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAlarm : MonoBehaviour
{
    public AudioSource _fireAlarm;
    public GameObject _title;
    public GameObject _notification;

    private void OnMouseOver()
    {
        _title.SetActive(true);

        if (Input.GetMouseButton(0))
        {
            _fireAlarm.Play();
            _notification.SetActive(true);
        }

    }

    private void OnMouseExit()
    {
        _title.SetActive(false);
    }

  
}
