using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sicScript : MonoBehaviour
{
    AudioSource ses;
    public GameObject bok;
    bool sictimi=false;
    public int cephane = 4;
    cephaneYenile pop;
    void Start()
    {
        pop = FindObjectOfType<cephaneYenile>();
        ses = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space)&&sictimi==false&&cephane>0)
        {
            StartCoroutine(sic());

            if (cephane < 4)
            {
                StartCoroutine(yenile());

            }
        }

        IEnumerator sic()
        {
            //pop.SetPoop(0);
            cephane -= 1;
            Debug.Log(cephane);
            sictimi = true;
            
            ses.Play();
            Instantiate(bok, transform.position, transform.rotation);
            
            yield return new WaitForSeconds(0.5f);
            sictimi = false;

            
        }
        //Debug.Log(sictimi);
    }


    IEnumerator yenile()
    {
        yield return new WaitForSeconds(10f);
        cephane+=1;
        yield return new WaitForSeconds(10f);
    }
}
