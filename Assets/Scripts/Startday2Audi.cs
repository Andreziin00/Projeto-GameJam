using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startday2Audi : MonoBehaviour
{
    public StoryElement2 Lohane;
    void Start()
    {
     if(GlobalDate.Day == 2)
        { 
        StartCoroutine(StartDialogue2());
        }  
    }

    IEnumerator StartDialogue2()
    {
        //

        yield return new WaitForSeconds(1f);

        Lohane.TriggerDialogue();
    }
}
