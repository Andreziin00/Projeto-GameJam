using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkedWithElisa : MonoBehaviour
{
    public static bool talkedLohane;

    void OnTriggerEnter2D(Collider2D other)
    {
     if(other.CompareTag("Player") && GlobalDate.Day == 2)
     {
      talkedLohane = true;
     }
    }
}
