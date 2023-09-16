using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class QTE : MonoBehaviour
{
    private MouseDrag mouseDrag;
    public Slider knifeSlider;
    public TextMeshProUGUI buttonSpec;

    public GameObject choppedHerb;
    public GameObject boomHerb;
    public GameObject itemSpawn;

    public GameObject QTETrigger;

    bool freeze;
    public int slowSpd;

    KeyCode key;
    KeyCode[] availableOptions = { KeyCode.Alpha1, KeyCode.Alpha2 };
    private bool inQteRange;

    void Start()
    {
        knifeSlider.gameObject.SetActive(false);

        SetSliderVal();
    }

    void Update()
    {
        if (inQteRange)
        {

          ChopQTE();
        }
    }

    private void ChopQTE()
    {
        knifeSlider.gameObject.SetActive(true);
        if (!freeze)
        {
            knifeSlider.value = Mathf.MoveTowards(knifeSlider.value, 0, slowSpd * Time.deltaTime);
        }

        
        if (Input.GetKeyDown(key) && knifeSlider.value > 0)
        {
                knifeSlider.value += 1;
            if (knifeSlider.value == 10)
            {
                buttonSpec.text = "Chopped";
                Destroy(boomHerb);
                Instantiate(choppedHerb, itemSpawn.transform.position, Quaternion.Euler(0, 0, 0));
                freeze = true;

            }
        }

        if (knifeSlider.value == 0)
        {
            buttonSpec.text = "Failed Chopping";
            freeze = true;
        }
    }

    void SetSliderVal()
    {
    
        int rand = Random.Range(0, 2);
        key = availableOptions[rand];
        buttonSpec.text = availableOptions[rand].ToString();
        knifeSlider.value = 10;
    }

    internal void StartQTE(GameObject gameObject)
    {
        inQteRange = true;
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.name.Contains("Herb"))
        {
            
            inQteRange = true;
            boomHerb = other.gameObject;

        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject == QTETrigger)
        {
            inQteRange = false;

        }

        if (other.name.Contains("choppedHerb"))
        {
            knifeSlider.gameObject.SetActive(false);
            SetSliderVal();
        }
    }

}
