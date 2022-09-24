using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryElement : MonoBehaviour
{
    public Dialogue dialogue;
    DialogueManager manager;
    void Start()
    {
     manager = FindObjectOfType<DialogueManager>();
    }

    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Space) && GlobalDate.Day == 1)
     {
      manager.DisplayNextSentences();
     }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
     if(other.CompareTag("Player") && GlobalDate.Day == 1)
     {
      TriggerDialogue();
     }
    }

    public void TriggerDialogue()
    {
     manager.StartDialogue(dialogue);
     Move.CanMove = false;
    }
}
