using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credits : MonoBehaviour
{
    public void OnApplicationQuit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
