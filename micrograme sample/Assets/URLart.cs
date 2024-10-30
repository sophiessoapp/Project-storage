using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLart : MonoBehaviour
{
    public void OpenURL()
    {
        //Copy your portfolio website URL and past here

        Application.OpenURL("https://sophiessoappcms.carrd.co/");
        Debug.Log("is this working");
    }
}
