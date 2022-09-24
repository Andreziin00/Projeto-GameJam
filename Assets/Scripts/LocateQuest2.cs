using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LocateQuest2 : MonoBehaviour
{
    public TextMeshProUGUI Objetivo;
    [TextArea(3,10)]
    public string DoString;
    void Start()
    {
     Objetivo = GameObject.Find("Obj").GetComponent<TextMeshProUGUI>();
     Objetivo.text = PlayerPrefs.GetString("Quest");
     if(PlayerPrefs.GetInt(this.gameObject.name + "X") != 0)
     {
      Destroy(this.gameObject);
     }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
     if(other.CompareTag("Player") && GlobalDate.Day == 2)
     {
      PlayerPrefs.SetString("Quest", DoString);
      Objetivo.text = PlayerPrefs.GetString("Quest");
      PlayerPrefs.SetInt(this.gameObject.name + "X", 2);
      Destroy(this.gameObject);
     }
    }
}
