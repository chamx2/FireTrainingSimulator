using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class VRWalkController : MonoBehaviour
{

    public Transform vrCamera;

    public float moveSpeed = 50.0f;

    private CharacterController cc;

    RaycastHit hit;

    public bool _triggerEnter;
    public GameObject _collisionWith;

    public bool playerMovement;
    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
            if (playerMovement)
            {
                //Debug.Log("Enable Walking");
                if (Input.GetMouseButton(0))
                {
                    Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
                    cc.SimpleMove(forward * moveSpeed * Time.deltaTime);
                }

            }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Quiz1")
        {
            _triggerEnter = true;
        }

        if(other.tag == "Quiz2")
        {
            _triggerEnter = true;
        }
    }



}
