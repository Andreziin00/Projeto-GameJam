using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasControl : MonoBehaviour
{
    public TextMeshProUGUI Dias;
    // Start is called before the first frame update
    void Start()
    {
     Dias = GameObject.Find("DiasCount").GetComponent<TextMeshProUGUI>();   
     Dias.text = "Dia: " + GlobalDate.Day; 
    }
}
