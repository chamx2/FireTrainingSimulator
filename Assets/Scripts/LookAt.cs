using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

	Transform player;

	void Update () {

		player = GameObject.FindGameObjectWithTag ("MainCamera").transform;
		transform.LookAt (player);
        transform.Rotate(0, 180, 0);
	}
}
