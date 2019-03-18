using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireParticleTriggerScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.SmokeEffectGameObject().SetActive(false);
        GameManager.Instance.ActivateFireParticles();
        GameManager.Instance.DisablePlayerWalk();
        GameManager.Instance.RunWarningMessage().SetActive(true);
    }
}
