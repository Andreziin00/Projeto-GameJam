using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartIntro : MonoBehaviour
{
    public StoryElement player;
    void Start()
    {
        StartCoroutine(StartDialogue());
    }

    IEnumerator StartDialogue()
    {
        //

        yield return new WaitForSeconds(1f);

        player.TriggerDialogue();
    }
}
