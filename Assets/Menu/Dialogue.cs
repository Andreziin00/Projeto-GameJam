using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Dialogue
{
    public string Name;
    [TextArea(5,10)]
    public string[] sentences;
}
