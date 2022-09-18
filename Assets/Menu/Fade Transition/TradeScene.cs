using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TradeScene : MonoBehaviour
{
    public void GoToHouse()
    {
     SceneManager.LoadScene("house");
    }
}
