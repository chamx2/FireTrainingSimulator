using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTriggerScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.DisablePlayerWalk();
        GameManager.Instance.EndTrialMessage().SetActive(true);
    }
}
