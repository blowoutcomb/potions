using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QTE : MonoBehaviour
{
    public Slider knifeSlider;
    public TextMeshProUGUI buttonSpec;

    public GameObject choppedHerb;
    public GameObject itemSpawn;

    bool freeze;

    public bool fastClick; 
    public int slowSpd;

    KeyCode key;
    KeyCode[] availableOptions = { KeyCode.Alpha1, KeyCode.Alpha2 }; 
    void Start()
    {
        

        int rand = Random.Range(0, 2);
        key = availableOptions[rand];
        buttonSpec.text = availableOptions[rand].ToString();
        if (fastClick)
        {
            knifeSlider.value = 5;
        }
        else
        {
            knifeSlider.value = 10;
        }
    }


    void Update()
    {    
        if (!freeze)
        {
            knifeSlider.value = Mathf.MoveTowards(knifeSlider.value, 0, slowSpd * Time.deltaTime);
        }

        if (fastClick)
        {
            if (Input.GetKeyDown(key) && knifeSlider.value > 0)
            {
                knifeSlider.value += 1;
                if (knifeSlider.value == 10)
                {
                    buttonSpec.text = "Chopped";
                    Instantiate(choppedHerb, itemSpawn.transform.position, Quaternion.Euler(0, 0, 0));
                    freeze = true;
                }
            }
        }

        if (!fastClick)
        {
            if (Input.GetKeyDown(key) && knifeSlider.value > 0)
            {
                buttonSpec.text = "Chopped!";

                
                freeze = true;
            }
        }

        if (knifeSlider.value == 0)
        {
            buttonSpec.text = "Failed Chopping";
            freeze = true;
        }
    }
}
