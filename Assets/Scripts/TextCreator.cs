using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TextCreator : MonoBehaviour //Controls how quickly to display the text on screen.
{
    public static TMPro.TMP_Text viewText;
    public static bool runTextPrint;
    public static int charCount; //character count
    [SerializeField] string transferText;
    [SerializeField] int internalCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalCount = charCount;
        charCount = GetComponent<TMPro.TMP_Text>().text.Length;
        if(runTextPrint == true)
        {
            runTextPrint = false;
            viewText = GetComponent<TMPro.TMP_Text>();
            transferText = viewText.text;
            viewText.text = "";
            StartCoroutine(RollText());
        }
    }

    IEnumerator RollText()
    {
        //for every character in the text display 1 letter and wait a certain amount of time to display the next.
        foreach (char c in transferText) 
        {
            viewText.text += c;
            yield return new WaitForSeconds(0.03f);
        }
    }
}
