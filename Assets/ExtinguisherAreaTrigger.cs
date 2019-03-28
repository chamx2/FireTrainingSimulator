using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguisherAreaTrigger : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {

        GameManager.Instance.ExtinguisherEffectGameObject().SetActive(true);
        GameManager.Instance.extinguisherAreaNotice.SetActive(false);
        GameManager.Instance.DisablePlayerWalk();
        GameManager.Instance.TrialThreeFlow();

    }

    private void OnTriggerExit(Collider other)
    {
        //GameManager.Instance.ExtinguisherEffectGameObject().SetActive(false);
        //GameManager.Instance.extinguisherStatus = false;
        GameManager.Instance.EnablePlayerWalk();
    }

    //void AllowWalk()
    //{
    //    StartCoroutine(AllowWalkInSeconds());
    //}

    //IEnumerator AllowWalkInSeconds()
    //{
    //    yield return new WaitForSeconds(5);
    //    //GameManager.Instance.extinguisherStatus = false;
    //    GameManager.Instance.EnablePlayerWalk();
         
    //}
}
