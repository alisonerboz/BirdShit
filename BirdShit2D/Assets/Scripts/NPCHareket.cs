using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCHareket : MonoBehaviour
{
    AudioSource ses;
    public Spawner spawner;
    public GameManager gm;
    float hiz = 15f;
    void Start()
    {
        ses = GetComponent<AudioSource>();
        gm = FindObjectOfType<GameManager>();
    }

    
    void Update()
    {
        transform.Translate(Vector2.left * hiz * Time.deltaTime);//sola hareket
    }

    private void OnCollisionEnter2D (Collision2D other)
    {
        /*if(other.gameObject.CompareTag("tetik"))
        {
            spawner.spawnla();
            Debug.Log("çarptý");
        }*/

        if(other.gameObject.CompareTag("BOK")) 
        {
            
            gm.SkorArtýr();
            Destroy(gameObject);
            

        }
    }
    
}

