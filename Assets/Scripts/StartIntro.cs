using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartIntro : MonoBehaviour
{
    public StoryElement player;
    public StoryElement2 player2;
    void Start()
    {
        if(GlobalDate.Day == 1)
        {
         StartCoroutine(StartDialogue());
        }
        if(GlobalDate.Day == 2)
        { 
        StartCoroutine(StartDialogue2());
        }
    }

    IEnumerator StartDialogue()
    {
        //

        yield return new WaitForSeconds(1f);

        player.TriggerDialogue();
    }
    IEnumerator StartDialogue2()
    {
        //

        yield return new WaitForSeconds(1f);

        player2.TriggerDialogue();
    }
}
