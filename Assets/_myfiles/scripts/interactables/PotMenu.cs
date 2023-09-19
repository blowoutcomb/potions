using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotMenu : MonoBehaviour
{
    [SerializeField] Button _potions;


    private void Start()
    {
        _potions.onClick.AddListener(PotionsStart);
    }

    private void PotionsStart()
    {
        //ScenesManager.Instance.PotionsStart();
    }
}
