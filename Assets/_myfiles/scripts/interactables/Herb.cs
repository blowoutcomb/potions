using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herb : MonoBehaviour
{
    public Transform herbObj;
    public GameObject herbSpawn;


    private void OnTriggerExit(Collider other)
    {

        Instantiate(herbObj, herbSpawn.transform.position, herbObj.rotation);
    }
}
