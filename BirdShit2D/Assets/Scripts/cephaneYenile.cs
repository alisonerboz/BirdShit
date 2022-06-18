using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cephaneYenile : MonoBehaviour
{
    public Slider slider;
    sicScript bok;

    void Start()
    {
        bok = FindObjectOfType<sicScript>();   
    }

    public void SetMaxPoop(int poop)
    {
        slider.maxValue = poop;
        slider.value = poop;
    }

    public void SetPoop(int poop) 
    {
        slider.value = poop;
    }
    
    void Update()
    {
        /*if(Input.GetKey(KeyCode.Space))
        {
            
        }
        if(bok.cephane<4)
        {
            //StartCoroutine(yenile());

        }*/

    }

    
}
