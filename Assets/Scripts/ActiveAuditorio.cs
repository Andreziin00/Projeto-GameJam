﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveAuditorio : MonoBehaviour
{
    public GameObject[] Npcs;
    void Start()
    {
    if(GlobalDate.Day == 2)
    {
      foreach (GameObject ob in Npcs)
      {
        ob.SetActive(true);
      }
    } 
    }
}
