using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFinalMenu : MonoBehaviour
{
    public GameObject ESCmenu;
    bool once;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(DialogueManager.Fim && once == false)
     {
      once = true;
      ESCmenu.SetActive(true);
     } 
    }
}
