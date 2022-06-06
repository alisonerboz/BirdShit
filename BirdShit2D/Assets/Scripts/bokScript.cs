using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bokScript : MonoBehaviour
{
    
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        rb.AddForce(Vector2.right*5);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "zemin")
        {
            Destroy(gameObject);
        }
    }
}
