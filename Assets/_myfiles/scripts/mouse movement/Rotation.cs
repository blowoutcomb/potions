using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] float rotSpeed = 100f;
    bool dragging = false;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDrag()
    {
        dragging = true;

    }

    private void Update()
    {
        if(Input.GetMouseButtonUp(2))
        {
            dragging = false;
        }
    }

    private void FixedUpdate()
    {
        if(dragging)
        {
            float x = Input.GetAxis("Mouse X") * rotSpeed * Time.fixedDeltaTime;
            float y = Input.GetAxis("Mouse Y") * rotSpeed * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down * x);
            rb.AddTorque(Vector3.right * y);
        }
    }
}
