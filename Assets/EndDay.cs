using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDay : MonoBehaviour
{
    public void TradeToIntro2()
    {
        StartCoroutine(LoadLevel("intro"));
    }
    IEnumerator LoadLevel(string levelname)
    {
        Debug.Log("StartAnimãção");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelname);
    }
}
