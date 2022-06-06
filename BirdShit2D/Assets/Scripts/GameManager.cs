using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    AudioSource ses;
    public int skor = 0;
    public Text skorText;
    void Start()
    {
        ses = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        skorText.text = "Skor : " + skor;
    }
    public void SkorArtýr()
    {
        skor++;
        ses.Play();
    }
}
