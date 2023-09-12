using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public Transform herbObj;
  

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        //Debug.Log("click");
        Instantiate( herbObj, new Vector3(4, 2, -1), herbObj.rotation);
    }
}
