using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SameText : MonoBehaviour
{
    public TextMeshProUGUI Objetivo;
    void Start()
    {
     Objetivo = GameObject.Find("Obj").GetComponent<TextMeshProUGUI>();
     Objetivo.text = PlayerPrefs.GetString("Quest");
    }
}
