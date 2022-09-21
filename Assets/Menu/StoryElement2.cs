using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryElement2 : MonoBehaviour
{
    public Dialogue dialogue;
    DialogueManager manager;
    Move jogador;
    public bool you = false;
    void Start()
    {
     manager = FindObjectOfType<DialogueManager>();
     jogador = GameObject.Find("Player").GetComponent<Move>();
    }

    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Space) && GlobalDate.Day == 2 && you)
     {
      manager.DisplayNextSentences();
     }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
     if(other.CompareTag("Player") && GlobalDate.Day == 2)
     {
      you = true;
      TriggerDialogue();
     }
    }
    void OnTriggerExit2D(Collider2D other)
    {
     you = false;
    }

    public void TriggerDialogue()
    {
     manager.StartDialogue(dialogue);
     jogador.CanMove = false;
    }
}
