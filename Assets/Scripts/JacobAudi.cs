using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JacobAudi : MonoBehaviour
{
    public GameObject[] npcsBath;
    public GameObject[] npcsSala2;
    public GameObject[] npcsLibrary;
    public GameObject[] npcsaudi;

    // Update is called once per frame
    void Awake()
    {
     //Jacob
     if(GlobalDate.Day == 1 && TalkedWithElisa.talkedJacob1)
     {
      foreach (GameObject np in npcsBath)
      {
       np.SetActive(true);
      }
     }
     //Lucas
     if(GlobalDate.Day == 1 && TalkedWithElisa.talkedLucas)
     {
      foreach (GameObject np in npcsSala2)
      {
       np.SetActive(true);
      }
     }
     //Eryck
      if(GlobalDate.Day == 1 && TalkedWithElisa.talkedEryck)
     {
      foreach (GameObject np in npcsLibrary)
      {
       np.SetActive(true);
      }
     }
     //Jacob2
     if(GlobalDate.Day == 1 && TalkedWithElisa.talkedJacob2)
     {
      foreach (GameObject np in npcsaudi)
      {
       np.SetActive(true);
      }
     }   
    }
}
