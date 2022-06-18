using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KusYonlendir : MonoBehaviour
{
    [Range(-10f, 10f)] public float yon=0;
    sicScript cep;
    void Start()
    {
        cep = FindObjectOfType<sicScript>();
    }

    
    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            
            transform.Rotate(0, 0, yon+7f * Time.deltaTime * 10f);
            
        }
        if (Input.GetKey(KeyCode.S))
        {

            transform.Rotate(0, 0, yon - 7f * Time.deltaTime * 10f);

        }
        else
        {
            if (transform.rotation.z>0)
            {
                transform.Rotate(0, 0, -1);//*Time.deltaTime);
            }
            if (transform.rotation.z < 0)
            {
                transform.Rotate(0, 0, +1); //* Time.deltaTime);
            }
            
        }
            


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="npc")
        {
            
            Destroy(collision.gameObject);
            
            SceneManager.LoadScene(1);
        }
        if (collision.gameObject.tag == "elma")
        {
            cep.cephane = 4;
            Destroy(collision.gameObject);

            
        }

    }
}
