using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayOneFim : MonoBehaviour
{
    public DialogueManager dia;
    public Animator Fadeanim;

    // Update is called once per frame
    void Update()
    {
        if (dia.Fim)
        {
            StartCoroutine(LoadLevel("Intro2"));
        }
    }
    IEnumerator LoadLevel(string levelname)
    {
        Fadeanim.SetTrigger("Start");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelname);
    }
}
