using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESCcontroller : MonoBehaviour
{
    public GameObject Esc;
    public Animator EscAnim;
    int once = 0;
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape))
      {
       once += 1;
      }
      if(Input.GetKeyDown(KeyCode.Escape) && once == 1)
      {
       Move.CanMove = false;
       Esc.SetActive(true);
      }  
      if(Input.GetKeyDown(KeyCode.Escape) && once == 2)
      {
       StartCoroutine(DisableMap());
      }
    }
    IEnumerator DisableMap()
    {
     EscAnim.SetTrigger("Close");
     yield return new WaitForSeconds(0.15f);
     Esc.SetActive(false);
     Move.CanMove = true;
     once = 0;
    }
}
