using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalDate : MonoBehaviour
{
    public static int Day = 1;

    public static void NextDay()
    {
     Day = 2;
    }
}
