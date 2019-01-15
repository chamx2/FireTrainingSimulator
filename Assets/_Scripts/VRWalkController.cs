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


    public bool playerMovement;
    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();
        //playerMovement = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        // if (GameManager.Instance.gameStart)
        // {
            if (playerMovement)
            {
                //Debug.Log("Enable Walking");
                if (Input.GetMouseButton(0))
                {
                    Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
                    cc.SimpleMove(forward * moveSpeed * Time.deltaTime);
                }

            //if (Physics.Raycast(transform.position, transform.forward, out hit, 100))
            //{
            //    if (hit.collider.gameObject.CompareTag("Trash"))
            //    {
            //        Debug.Log("Trash Found!");
            //        GameManager.Instance.SetCurrentTrashItem(hit.collider.gameObject);
            //        //hit.collider.gameObject.GetComponent<DragDropItem>().yourFunction();
            //    }

            //}
        }
    //}
}

    public void EnablePlayerWalk()
    {
        playerMovement = true;
    }

    public void DisablePlayerWalk()
    {
        playerMovement = false;
    }

   
}
