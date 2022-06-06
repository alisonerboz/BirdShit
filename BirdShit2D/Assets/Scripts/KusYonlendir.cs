using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KusYonlendir : MonoBehaviour
{
    [Range(-10f, 10f)] public float yon=0;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            
            transform.Rotate(0, 0, yon+5f * Time.deltaTime * 10f);
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            
            transform.Rotate(0, 0, yon-5f * Time.deltaTime * 10f);
            
        }

        transform.Rotate(0, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="npc")
        {
            Destroy(collision.gameObject);
            Debug.Log("Kuþ Öldü");
            Time.timeScale = 0;
        }
        
    }
}
