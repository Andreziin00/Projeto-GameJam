using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeEliForLoha : MonoBehaviour
{
   public GameObject[] NpcLibrary1;
   public GameObject[] NpcSala1;
   public GameObject[] NpcLibrary2;
    void Awake()
    {
     //falei com elisa no refeitorio
     if(GlobalDate.Day == 2 && TalkedWithElisa.talkedElisa1)
     {
      foreach (GameObject np in NpcLibrary1)
      {
       np.SetActive(true);
      }
     }
     //falei com elisa na biblioteca
     if(GlobalDate.Day == 2 && TalkedWithElisa.talkedElisa2)
     {
      foreach (GameObject np in NpcSala1)
      {
       np.SetActive(true);
      }
     }
     //falei com lohane na sala
     if(GlobalDate.Day == 2 && TalkedWithElisa.talkedLohane1)
     {
      foreach (GameObject np in NpcLibrary1)
      {
       np.SetActive(false);
      }
       foreach (GameObject np in NpcLibrary2)
      {
       np.SetActive(true);
      }
     }
     //falei com lohane na biblioteca
    }
}
