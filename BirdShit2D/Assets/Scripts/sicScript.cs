using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sicScript : MonoBehaviour
{
    AudioSource ses;
    public GameObject bok;
    void Start()
    {
        ses = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            ses.Play();
            Instantiate(bok, transform.position, transform.rotation);
        }
    }
}
