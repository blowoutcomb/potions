using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    private int pMushNum;
    private int cHerb;
    private int nHerb;

    private int ingNum = 0;
    private int ingNumMax = 3;

    public GameObject pPot;
    public GameObject bPot;
    public GameObject gPot;
    public GameObject lPot;
    public GameObject tPot;
    public GameObject wrongPot;

    public GameObject potSpawn;


    private void OnTriggerEnter(Collider other)
    {
        ingNum++;
        if (other.name.Contains("pMush"))
        {
            pMushNum++;
        }
        else if (other.name.Contains("choppedHerb"))
        {
            cHerb++;
        }
        else if (other.name.Contains("Herb"))
        {
            nHerb++;
        }
        if(ingNum == ingNumMax)
        {
            CreatePot();
        }

        Destroy(other.gameObject);
    }

    private void CreatePot()
    {


        if (pMushNum == 2 && cHerb == 1)
        {
            Instantiate(pPot);

        }
        else if (nHerb == 2 && pMushNum == 1)
        {
            Instantiate(lPot);
        }

        else if (cHerb == 3)
        {
            Instantiate(tPot);
        }
        else if (pMushNum == 3)
        {
            Instantiate(bPot);
        }
        else if (nHerb == 3)
        {
            Instantiate(gPot);
        }
        else
        {
            Instantiate(wrongPot);
        }

        ingNum = 0;
        pMushNum = 0;
        cHerb = 0;
        nHerb = 0;
    }
}
