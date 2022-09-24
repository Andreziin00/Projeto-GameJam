using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptManagerDialogue : MonoBehaviour
{
    public Animator Fadeanim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(DialogueManager.Fim)
        {
            StartCoroutine(LoadLevel("house"));
        }
    }
    IEnumerator LoadLevel(string levelname)
    {
        Fadeanim.SetTrigger("Start");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelname);
    }
}
