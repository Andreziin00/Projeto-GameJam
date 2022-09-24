using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapaController : MonoBehaviour
{
    public GameObject Map;
    public Animator MapAnim;
    int once = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.M))
      {
       once += 1;
      }
      if(Input.GetKeyDown(KeyCode.M) && once == 1)
      {
       Move.CanMove = false;
       Map.SetActive(true);
      }  
      if(Input.GetKeyDown(KeyCode.M) && once == 2)
      {
       StartCoroutine(DisableMap());
      }
    }
    IEnumerator DisableMap()
    {
     MapAnim.SetTrigger("Close");
     yield return new WaitForSeconds(0.15f);
     Map.SetActive(false);
     Move.CanMove = true;
     once = 0;
    }
}
