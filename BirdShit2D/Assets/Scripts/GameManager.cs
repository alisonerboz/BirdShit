using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    AudioSource ses;
    public int skor = 0;
    public Text skorText;
    sicScript bok;

    public GameObject Bok1;
    public GameObject Bok2;
    public GameObject Bok3;
    public GameObject Bok4;
    void Start()
    {
        bok = FindObjectOfType<sicScript>();
        ses = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        skorText.text = "" + skor;

        if ( bok.cephane== 4)
        {
            Bok1.SetActive(true);
            Bok2.SetActive(true);
            Bok3.SetActive(true);
            Bok4.SetActive(true);
        }
        else if (bok.cephane == 3)
        {
            Bok1.SetActive(true);
            Bok2.SetActive(true);
            Bok3.SetActive(true);
            Bok4.SetActive(false);

        }
        else if (bok.cephane == 2)
        {
            Bok1.SetActive(true);
            Bok2.SetActive(true);
            Bok3.SetActive(false);
            Bok4.SetActive(false);

        }
        else if (bok.cephane == 1)
        {
            Bok1.SetActive(true);
            Bok2.SetActive(false);
            Bok3.SetActive(false);
            Bok4.SetActive(false);
        }
        else if (bok.cephane == 0)
        {
            Bok1.SetActive(false);
            Bok2.SetActive(false);
            Bok3.SetActive(false);
            Bok4.SetActive(false);
        }
    }
    public void SkorArtýr()
    {
        skor+=10;
        ses.Play();
    }
}
