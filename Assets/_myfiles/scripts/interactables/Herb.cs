using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herb : MonoBehaviour
{
    public Transform herbObj;
    public GameObject herbSpawn;


    private void OnMouseDown()
    {
        //Debug.Log("click");
        Instantiate(herbObj, herbSpawn.transform.position, herbObj.rotation);
    }
}
