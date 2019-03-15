using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTriggerScript : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.SparkEffectGameObject().SetActive(false);
        GameManager.Instance.ActivateExplosions();
        GameManager.Instance.SmokeEffectGameObject().SetActive(true);
    }
}
