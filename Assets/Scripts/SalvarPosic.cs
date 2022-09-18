using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalvarPosic : MonoBehaviour
{
    string nomeCenaAtual;
    void Awake()
    {
     nomeCenaAtual = SceneManager.GetActiveScene().name;
    }
    void Start()
    {
     if(PlayerPrefs.HasKey(nomeCenaAtual + "X") && PlayerPrefs.HasKey(nomeCenaAtual + "Y"))
     {
      transform.position = new Vector2(PlayerPrefs.GetFloat(nomeCenaAtual + "X"), PlayerPrefs.GetFloat(nomeCenaAtual + "Y"));
     }
    }
    public void SalvarPosicao(int diferenceX, int diferenceY)
    {
     PlayerPrefs.SetFloat(nomeCenaAtual + "X", transform.position.x - diferenceX);
     PlayerPrefs.SetFloat(nomeCenaAtual + "Y", transform.position.y - diferenceY);
    }
}
