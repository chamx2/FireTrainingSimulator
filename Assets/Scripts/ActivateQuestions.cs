using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateQuestions : MonoBehaviour
{
    public GameObject _questionUI;

    private void OnTriggerEnter(Collider other)
    {
        _questionUI.SetActive(true);
    }

    public void DestroyTrigger()
    {
        Destroy(this.gameObject);
    }
}
