using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            Debug.Log("Ku� �ld�");
            Time.timeScale = 0;
            SceneManager.LoadScene(1);
        }
        
    }
}
