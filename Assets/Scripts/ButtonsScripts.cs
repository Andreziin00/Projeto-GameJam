using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScripts : MonoBehaviour
{
    public GameObject Credts;
    public void JogarNovamente()
    {
     PlayerPrefs.DeleteAll();
     SceneManager.LoadScene("Intro");
    }
    public void Creditos()
    {
     Credts.SetActive(true);
    }
    public void Sair()
    {
     Application.Quit();
    }
    public void FecharGuia()
    {
     Credts.SetActive(false);
    }
}
