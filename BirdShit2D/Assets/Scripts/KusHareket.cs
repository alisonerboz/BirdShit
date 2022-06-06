using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KusHareket : MonoBehaviour
{
    public float hiz = 15f;
    Rigidbody2D rb;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, +1*Time.deltaTime*hiz, 0);
            
            Debug.Log("Yukarý");
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -1 * Time.deltaTime*hiz, 0);
            
            Debug.Log("Aþaðý");
        }

        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("npc"))
        {

            Debug.Log("Kuþ Öldü");
            Time.timeScale = 0;
        }
        
    }
}
