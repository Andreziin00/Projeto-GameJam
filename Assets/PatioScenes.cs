using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PatioScenes : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
     if(other.CompareTag("p1"))
     {
      SceneManager.LoadScene(6);
     }
     //p2 e p3 locked
     if(other.CompareTag("p4"))
     {
      SceneManager.LoadScene(3);
     }
     if(other.CompareTag("PA"))
     {
      SceneManager.LoadScene(2);
     }
      if(other.CompareTag("Ref"))
     {
      SceneManager.LoadScene(7);
     }
     if(other.CompareTag("E1"))
     {
      SceneManager.LoadScene(1);
     }
     if(other.CompareTag("E2"))
     {
      SceneManager.LoadScene(1);
     }
     //
     if(other.CompareTag("Coz"))
     {
      SceneManager.LoadScene(5);
     }
    }
}
