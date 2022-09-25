using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkedWithElisa : MonoBehaviour
{
    //Dia 2
    public static bool talkedElisa1; // refeitorio
    public static bool talkedElisa2; // biblioteca
    public static bool talkedLohane1; // sala 1
    public static bool talkedLohane2; // biblioteca
    //Dia 1
    public static bool talkedJacob1;
    public static bool talkedJacob2;
    public static bool talkedEryck;
    public static bool talkedLucas;
    void Start()
    {
     
    }

    void OnTriggerEnter2D(Collider2D other)
    {
     //Dia2
     if(this.enabled)
     {
        if(other.CompareTag("Player") && GlobalDate.Day == 2 && PlayerPrefs.GetInt("CountEventD2") == 0 && PlayerPrefs.GetInt(this.gameObject.name) == 0)
     {
      talkedElisa1 = true;
      Debug.Log("Elisa1 "+ talkedElisa1);
      PlayerPrefs.SetInt("CountEventD2", 1);
      PlayerPrefs.SetInt(this.gameObject.name, 1);
     }
     else
     if(other.CompareTag("Player") && GlobalDate.Day == 2 && talkedElisa1 && PlayerPrefs.GetInt("CountEventD2") == 1 && PlayerPrefs.GetInt(this.gameObject.name) == 0)
     {
      talkedElisa2 = true;
      Debug.Log("Elisa2 "+talkedElisa2);
      PlayerPrefs.SetInt("CountEventD2", 2);
      PlayerPrefs.SetInt(this.gameObject.name, 1);
     }
     else
     if(other.CompareTag("Player") && GlobalDate.Day == 2 && talkedElisa2 && PlayerPrefs.GetInt("CountEventD2") == 2 && PlayerPrefs.GetInt(this.gameObject.name) == 0)
     {
      talkedLohane1 = true;
      Debug.Log("Lohane1 "+talkedLohane1);
      PlayerPrefs.SetInt("CountEventD2", 3);
      PlayerPrefs.SetInt(this.gameObject.name, 1);
     }
     else
     if(other.CompareTag("Player") && GlobalDate.Day == 2 && talkedLohane1 && PlayerPrefs.GetInt("CountEventD2") == 3 && PlayerPrefs.GetInt(this.gameObject.name) == 0)
     {
      talkedLohane2 = true;
      Debug.Log("Lohane2 "+talkedLohane2);
      PlayerPrefs.SetInt(this.gameObject.name, 1);
     }
     }
     
     //Dia1
     if(other.CompareTag("Player") && GlobalDate.Day == 1 && PlayerPrefs.GetInt("CountEventD1") == 0 && PlayerPrefs.GetInt(this.gameObject.name) == 0)
     {
      talkedJacob1 = true;
      Debug.Log("Jacob1 "+talkedJacob1);
      PlayerPrefs.SetInt("CountEventD1", 1);
      PlayerPrefs.SetInt(this.gameObject.name, 1);
      //os prefabs do banheiro são ativos.
     }
     if(other.CompareTag("Player") && GlobalDate.Day == 1 && talkedJacob1 && PlayerPrefs.GetInt("CountEventD1") == 1 && PlayerPrefs.GetInt(this.gameObject.name) == 0)
     {
      talkedLucas = true;
      Debug.Log("Lucas "+talkedLucas);
      PlayerPrefs.SetInt("CountEventD1", 2);
      PlayerPrefs.SetInt(this.gameObject.name, 1);
      //prefab 2°andar e sala 2 são ativos.
     }
     if(other.CompareTag("Player") && GlobalDate.Day == 1 && talkedLucas && PlayerPrefs.GetInt("CountEventD1") == 2 && PlayerPrefs.GetInt(this.gameObject.name) == 0)
     {
      talkedEryck = true;
      Debug.Log("Eryck "+talkedEryck);
      PlayerPrefs.SetInt("CountEventD1", 3);
      PlayerPrefs.SetInt(this.gameObject.name, 1);
      //prefab biblioteca são ativos.
     }
     if(other.CompareTag("Player") && GlobalDate.Day == 1 && talkedEryck && PlayerPrefs.GetInt("CountEventD1") == 3 && PlayerPrefs.GetInt(this.gameObject.name) == 0)
     {
      talkedJacob2 = true;
      Debug.Log("Jacob2 "+talkedJacob2);
      PlayerPrefs.SetInt(this.gameObject.name, 1);
      //prefab auditorio são ativos.
     }
    }
}
