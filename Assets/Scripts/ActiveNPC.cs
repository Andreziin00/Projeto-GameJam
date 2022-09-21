using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveNPC : MonoBehaviour
{
    public GameObject Lukagood;
    void Start()
    {
    if(GlobalDate.Day == 2)
    {
      Lukagood.SetActive(true);
    } 
    }
}
