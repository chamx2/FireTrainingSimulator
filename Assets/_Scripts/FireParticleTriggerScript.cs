using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireParticleTriggerScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Destroy(GameManager.Instance.smokeEffect);
        Destroy(GameManager.Instance.explosionEffectsParent);
        //GameManager.Instance.SmokeEffectGameObject().SetActive(false);
        GameManager.Instance.StopExplosionSoundEffect();
        GameManager.Instance.ActivateFireParticles();
        GameManager.Instance.DisablePlayerWalk();
        GameManager.Instance.RunWarningMessage().SetActive(true);
    }
}
