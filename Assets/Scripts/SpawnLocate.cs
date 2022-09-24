using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLocate : MonoBehaviour
{
    public float X1,X2,X3,X4;
    public float Y1,Y2,Y3,Y4;
    public GameObject Prefab;
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject Prefab4;
    void Start()
    {
     if(Prefab != null)
     {
      Instantiate(Prefab, new Vector2(X1,Y1), Quaternion.identity);
     }   
     if(Prefab2 != null)
     {
      Instantiate(Prefab2, new Vector2(X2,Y2), Quaternion.identity);
     }  
     if(Prefab3 != null)
     {
      Instantiate(Prefab3, new Vector2(X3,Y3), Quaternion.identity);
     }  
     if(Prefab4 != null)
     {
      Instantiate(Prefab4, new Vector2(X4,Y4), Quaternion.identity);
     }  
    }
}
