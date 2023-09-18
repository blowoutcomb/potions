using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public Transform mushObj;
    public GameObject mushSpawn;


    private void OnTriggerExit(Collider other)
    {

        Instantiate(mushObj, mushSpawn.transform.position, mushObj.rotation);
    }
}
