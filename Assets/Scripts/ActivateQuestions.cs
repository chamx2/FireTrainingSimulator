using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateQuestions : MonoBehaviour
{
    public GameObject _questionUI;
    public GameObject _smokeEffect;

    private void OnTriggerEnter(Collider other)
    {
        _questionUI.SetActive(true);
        _smokeEffect.SetActive(true);
    }

    public void DestroyTrigger()
    {
        Destroy(this.gameObject);
    }
}
