using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {


	Transform player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		player = GameObject.FindGameObjectWithTag ("MainCamera").transform;
		transform.LookAt (2 * transform.position - player.position);
	}
}
