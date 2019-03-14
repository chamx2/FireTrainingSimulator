using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsManager : MonoBehaviour
{
    private static EffectsManager instance;

    public static EffectsManager Instance { get { return instance; } }

    //effects reference here
    public List<GameObject> effects;

    void Awake()
    {
        instance = this;
    }


    public void ActivateEffect()
    {

    }
	
}
