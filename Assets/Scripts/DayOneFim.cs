using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayOneFim : MonoBehaviour
{
    public Animator Fadeanim;

    // Update is called once per frame
    void Update()
    {
        if (GlobalDate.Day == 1 && DialogueManager.Fim)
        {
            GlobalDate.NextDay();
            PlayerPrefs.DeleteAll();
            Debug.Log(GlobalDate.Day);
            StartCoroutine(LoadLevel("Intro2"));
        }
        if(GlobalDate.Day == 2 && DialogueManager.Fim && TalkedWithElisa.talkedLohane2)
        {
         StartCoroutine(LoadLevel("Fim"));
        }
    }
    IEnumerator LoadLevel(string levelname)
    {
        Fadeanim.SetTrigger("Start");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelname);
    }
}
