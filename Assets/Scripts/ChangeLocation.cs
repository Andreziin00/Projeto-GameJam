using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLocation : MonoBehaviour
{
    public float PositionX, PositionY;
    public bool NoStay;
    void Start()
    {
     if(GlobalDate.Day == 2)
     {
        if(PositionX != 0 && PositionY != 0)
        {   
         transform.position = new Vector2(PositionX, PositionY);
        }
     if(this.gameObject.name == "Player")
     {
      Move.CanMove = false;
     }
     if(NoStay)
     {
      Destroy(this.gameObject);
     }
     }
    }
}
