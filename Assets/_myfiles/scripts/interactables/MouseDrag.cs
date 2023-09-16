using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{

    Rigidbody body;

    private QTE qte;
    public Vector3 mouseSpeed = Vector3.zero;
    public Vector3 lastMousePos = Vector3.zero;
    public bool inQteRange;

    private void Awake()
    {
        qte = FindObjectOfType<QTE>(); 
    }
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
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y,
            -Camera.main.transform.position.z + Input.mousePosition.z);
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
