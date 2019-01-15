using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDecay : MonoBehaviour
{

    private void Start()
    {
        
        Destroy(this.gameObject, 5);
    }
}
