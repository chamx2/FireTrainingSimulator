using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragItem : MonoBehaviour {

    void OnMouseDown()
    {
        //Debug.Log("Dragging Object");
        GameManager.Instance.SetCurrentTrashItem(this.gameObject);
        GameManager.Instance.clickObject();
    }
    void OnMouseDrag()
    {

    }

    void OnMouseUp()
    {
        //Debug.Log("Letting Go of the object");
        //GameManager.Instance.letGoObject();
    }

}
