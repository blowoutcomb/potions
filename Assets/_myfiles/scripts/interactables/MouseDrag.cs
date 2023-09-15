using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    /*
    private Vector3 mOffset;

    private float mZCoord;

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.x = mZCoord;

        return Camera.main.WorldToScreenPoint(mousePoint);

    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }
    */


    Rigidbody body;

   
    public Vector3 mouseSpeed = Vector3.zero;
    public Vector3 lastMousePos = Vector3.zero;
   
    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
      
        mouseSpeed = Input.mousePosition - lastMousePos;
        lastMousePos = Input.mousePosition;
    }


   

    private void OnMouseDrag()
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z + Input.mousePosition.z);
        Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);
        objPos = new Vector3( objPos.x, objPos.y, -0.35f);

        transform.position = objPos;
        body.isKinematic = true;
    }

   
    private void OnMouseUp()
    {
        body.isKinematic = false;

    }

  
}
