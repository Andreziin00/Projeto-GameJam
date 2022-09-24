using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionTOAudi : MonoBehaviour
{
    public Animator Fadeanim;

    // Update is called once per frame
    void Update()
    {
        if (DialogueManager.Fim && TalkedWithElisa.talkedLohane)
        {
            StartCoroutine(LoadLevel("auditorio"));
        }
    }
    IEnumerator LoadLevel(string levelname)
    {
        Fadeanim.SetTrigger("Start");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelname);
    }
}
