using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sicScript : MonoBehaviour
{
    AudioSource ses;
    public GameObject bok;
    bool sictimi=false;
    void Start()
    {
        ses = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space)&&sictimi==false)
        {
            StartCoroutine(sic());
            
            
        }

        IEnumerator sic()
        {
            sictimi = true;
            
            ses.Play();
            Instantiate(bok, transform.position, transform.rotation);
            
            yield return new WaitForSeconds(0.5f);
            sictimi = false;
        }
        Debug.Log(sictimi);
    }
}
