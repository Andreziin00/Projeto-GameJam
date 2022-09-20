using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public Animator Fadeanim;
    SalvarPosic Jogador;
    void Start()
    {
     Jogador = GetComponent<SalvarPosic>();
     Fadeanim = GameObject.Find("LoadLevel").GetComponentInChildren<Animator>();
    }
   void OnTriggerEnter2D(Collider2D other)
    {
     if(other.CompareTag("pcasa"))
     {
      //pcasa = porta da casa
      StartCoroutine(LoadLevel("newSave"));
     }
     if(other.CompareTag("p1"))
     {
        //p1 = livraria
      StartCoroutine(LoadLevel("library"));
      Jogador.SalvarPosicao(0,1);
     }
     //p2 e p3 locked
     if(other.CompareTag("p4"))
     {
        //p4 = banheiro
      StartCoroutine(LoadLevel("bathroom"));
      Jogador.SalvarPosicao(0,1);

     }
     if(other.CompareTag("PA"))
     {
        //PA = porta auditorio
      StartCoroutine(LoadLevel("auditorio"));
      Jogador.SalvarPosicao(0,1);

     }
      if(other.CompareTag("Ref"))
     {
        //ref = refeitorio
      StartCoroutine(LoadLevel("refeitorio"));
      Jogador.SalvarPosicao(1,0);

     }
     if(other.CompareTag("E1"))
     {
        //E1 = Escadaria1
      StartCoroutine(LoadLevel("2andar"));
      Jogador.SalvarPosicao(0,1);

     }
     if(other.CompareTag("E2"))
     {
        //E2 = escadaria2
      StartCoroutine(LoadLevel("2andar"));
      Jogador.SalvarPosicao(0,1);

     }
     if(other.CompareTag("Coz"))
     {
        //Coz = porta da cozinha
        ////

      StartCoroutine(LoadLevel("kitchen"));
      Jogador.SalvarPosicao(0,-1);
     }
     if(other.CompareTag("Pclass1"))
     {
            //
        //Pclass1 = porta da sala1
      StartCoroutine(LoadLevel("classroom"));
      Jogador.SalvarPosicao(0,1);
     }
     if(other.CompareTag("Pclass2"))
     {
        //Pclass1 = porta da sala2
      StartCoroutine(LoadLevel("classroom2"));
      Jogador.SalvarPosicao(0,1);
     }
     if(other.CompareTag("Pclass3"))
     {
        //Pclass1 = porta da sala3
        //
      StartCoroutine(LoadLevel("classroom3"));
      Jogador.SalvarPosicao(0,1);
     }
     if(other.CompareTag("Pclass4"))
     {
        //Pclass1 = porta da sala4
        //
      StartCoroutine(LoadLevel("classroom4"));
      Jogador.SalvarPosicao(0,1);
     }
    }
    IEnumerator LoadLevel(string levelname)
    {
     Fadeanim.SetTrigger("Start");

     yield return new WaitForSeconds(1f);

     SceneManager.LoadScene(levelname);
    }
}
