using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryElement : MonoBehaviour
{
    public Dialogue dialogue;
    DialogueManager manager;
    Move jogador;
    void Start()
    {
     manager = FindObjectOfType<DialogueManager>();
     jogador = GameObject.Find("Player").GetComponent<Move>();
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
     jogador.CanMove = false;
    }
}
