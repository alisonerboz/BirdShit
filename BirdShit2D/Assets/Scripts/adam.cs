using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adam : MonoBehaviour
{
    SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }


    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.gameObject.tag == "BOK")
        {
            sr.sprite.name ="kus.png";
        }*/
    }
}
