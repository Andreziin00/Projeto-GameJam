using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    // Referencias UI Text
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI DialogueText;
    public AudioSource lettersound;
    public AudioSource Fimdialogo1;
    //
    public static bool Fim;
    public Animator anim;
    public Queue<string> Sentences;
    //
    void Start()
    {
    Fim = false;
    Sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
     anim.SetBool("IsOpen", true);
     Debug.Log("Começando a conversa com " + dialogue.Name);
     NameText.text = dialogue.Name;
     Sentences.Clear();

     foreach(string sentence in dialogue.sentences)
     {
      Sentences.Enqueue(sentence);
     }
     DisplayNextSentences();
    }
    public void DisplayNextSentences()
    {
     if(Sentences.Count == 0)
     {
      EndDialogue();
      return;
     }
     string sentence = Sentences.Dequeue();
     StopAllCoroutines();
     StartCoroutine(TypeSentences(sentence));
    }

    IEnumerator TypeSentences(string sentence)
    {
     DialogueText.text = "";
     foreach (char letter in sentence.ToCharArray())
     {
      lettersound.Play();
      DialogueText.text += letter;
      yield return null;
      lettersound.Stop();
     }
    }
    public void EndDialogue()
    {
        Fim = true;
     Fimdialogo1.Play();
     anim.SetBool("IsOpen", false);
     Move.CanMove = true;
    }
}
