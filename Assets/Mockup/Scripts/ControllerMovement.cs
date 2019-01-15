using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMovement : MonoBehaviour {


	void Start () {
		
		 
	}
	
		public float MovementSpeed = 10.0f;
		public float RotationSpeed = 100.0f;
	
	void Update () {

		 float translation = Input.GetAxis("Vertical") * MovementSpeed;
		 float rotation = Input.GetAxis("Horizontal") * RotationSpeed;
		 
		 translation *= Time.deltaTime;
		 rotation *= Time.deltaTime;

		 transform.Translate(0,0, translation);
		 transform.Rotate(rotation, 0, 0);

		
	}
}
