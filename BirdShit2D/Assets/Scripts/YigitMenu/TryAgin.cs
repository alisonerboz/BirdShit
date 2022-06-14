using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgin : MonoBehaviour
{
     public void Tryagain()
   {
       //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 1);
      // SceneManager.LoadScene("1");
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
      Time.timeScale = 1;
   }
    public void MainMenu()
   {
       
      SceneManager.LoadScene(0);
      
   }
}
