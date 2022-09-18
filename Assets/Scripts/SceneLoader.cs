using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator Fadeanim;
    string cenaatual;
    SalvarPosic Jogador;
    void Start()
    {
     cenaatual = SceneManager.GetActiveScene().name;
     Jogador = GameObject.Find("Player").GetComponent<SalvarPosic>();
     Fadeanim = GameObject.Find("LoadLevel").GetComponentInChildren<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Player") && cenaatual != "kitchen" && cenaatual != "2andar")
        {
            StartCoroutine(LoadLevel("newSave"));
        }
        if(collision.CompareTag("Player") && cenaatual == "kitchen")
        {
            StartCoroutine(LoadLevel("refeitorio"));
        }
        if(collision.CompareTag("Player") && cenaatual == "2andar")
        {
         Jogador.SalvarPosicao(0, -1);
         StartCoroutine(LoadLevel("newSave"));
        }
        if(collision.CompareTag("Player") && cenaatual == "classroom" || cenaatual == "classroom2" || cenaatual == "classroom3" || cenaatual == "classroom4")
        {
         StartCoroutine(LoadLevel("2andar"));
        }
    }
    IEnumerator LoadLevel(string levelname)
    {
     Fadeanim.SetTrigger("Start");

     yield return new WaitForSeconds(1f);

     SceneManager.LoadScene(levelname);
    }
}
