using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogBasoc : MonoBehaviour
{
    [SerializeField] private Text textDialog;
    private void Start()
    {
        StartCoroutine(DialogOpen("Ты что идиот?",2f));
    }
    private IEnumerator DialogOpen(string textStr,float speedTextScrol)
    {
        foreach(var sum in textStr)
        {
            textDialog.text += sum;
            yield return new WaitForSeconds(speedTextScrol);
        }
    }
}
