using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeEliForLoha : MonoBehaviour
{
   public GameObject Npc1;
   public GameObject Npc2;
   public GameObject Prof;
    void Start()
    {
     if(GlobalDate.Day == 2)
     {
      Npc1.SetActive(true);
      Npc2.SetActive(true);
     }
    }
    void Update()
    {
     if(TalkedWithElisa.talkedLohane)
     {
      Npc1.SetActive(false);
      Npc2.SetActive(false);
      Prof.SetActive(true);
     }
    }
}
