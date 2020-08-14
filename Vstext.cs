using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vstext : MonoBehaviour
{
    public Text textUI;

    private string text = "I'm sorry for interrupting... You don't know what will happen next? Do you really want to get there?";
   
    void Start()
    {
        StartCoroutine("showText", text);
    }

    IEnumerator showText(string text)
    {
        int i = 0;
        while (i <= text.Length)
        {
            textUI.text = text.Substring(0, i);
            i++;

            yield return new WaitForSeconds(0.1f);
        }
    }


   
}
