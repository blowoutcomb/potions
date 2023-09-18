using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    private bool isMushObj = false;
    private bool isChopObj = false;
    private bool isHerbObj = false;

    private int ingNum;
    private int ingNumMax = 3;

    public GameObject pPot;
    public GameObject bPot;
    public GameObject wPot;

    public GameObject potSpawn;


    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("pMush"))
        {
            ingNum++;
            isMushObj = true;
        }


        if (other.name.Contains("choppedHerb"))
        {
            ingNum++;
            isChopObj = true;
        }


        if (other.name.Contains("Herb"))
        {
            ingNum++;
            isHerbObj = true;
        }

        if(ingNum == ingNumMax)
        {
           
        }
    }

    private void OnTriggerExit(Collider other)
    {

       
    }



}
