using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Scene01Events : MonoBehaviour
{

    public GameObject fadeSceenIn;
    public GameObject charIsabelleThink; //Placeholder
    public GameObject charIsabelleGreet; //Placeholder
    public GameObject charIsabelleSerious; //Placeholder
    public GameObject charDoomGuy; //Placeholder
    public GameObject textBox;
    [SerializeField] AudioSource girlSigh; //Placeholder
    [SerializeField] AudioSource girlGasp; //Placeholder
    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject charName;
    [SerializeField] GameObject fadeOut;
    void Update()
    {
        textLength = TextCreator.charCount;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        // event 0
        yield return new WaitForSeconds(2);
        fadeSceenIn.SetActive(false);
        charIsabelleGreet.SetActive(false);
        charIsabelleThink.SetActive(true);
        yield return new WaitForSeconds(2);
        // text function added here.
        mainTextObject.SetActive(true);
        textToSpeak = "Such a beautiful day but I am so bored.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak; //Transfers to gameobject
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        girlSigh.Play();
        yield return new WaitForSeconds(.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(.05f);
        nextButton.SetActive(true);
        eventPos = 1;

    }
    IEnumerator Event1()
    {
        nextButton.SetActive(false);
        charDoomGuy.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "DoomGuy";
        textToSpeak = "Isabelle want to fight some DEMONS!?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak; //Transfers to gameobject
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(.05f);


        yield return new WaitForSeconds(2);
        girlGasp.Play();
        nextButton.SetActive(true);
        eventPos = 2;
    }
    IEnumerator Event2()
    {
        nextButton.SetActive(false);
        charDoomGuy.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Isabelle";
        textToSpeak = "SURE LETS SLAUGHTER THEM";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak; //Transfers to gameobject
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(.05f);
        nextButton.SetActive(true);
        eventPos = 3;
    }
    IEnumerator Event3()
    {
        nextButton.SetActive(false);
        charDoomGuy.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "DoomGuy";
        textToSpeak = "Great! Do you have a weapon?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak; //Transfers to gameobject
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(.05f);
        nextButton.SetActive(true);
        eventPos = 4;
    }
    IEnumerator Event4()
    {
        nextButton.SetActive(false);
        charDoomGuy.SetActive(true);
        charIsabelleThink.SetActive(false);
        charIsabelleSerious.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Isabelle";
        textToSpeak = "Armed and ready!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak; //Transfers to gameobject
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(.05f);
        nextButton.SetActive(true);
        eventPos = 5;
    }
    IEnumerator Event5()
    {
        nextButton.SetActive(false);
        charDoomGuy.SetActive(true);
        charIsabelleSerious.SetActive(true);
        textBox.SetActive(true);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
    public void NextButton()
    {
        if (eventPos == 1)
        {
            StartCoroutine(Event1());
        }
        if (eventPos == 2)
        {
            StartCoroutine(Event2());
        }
        if (eventPos == 3)
        {
            StartCoroutine(Event3());
        }
        if(eventPos == 4)
        {
            StartCoroutine(Event4());
        }
        if(eventPos == 5)
        {
            StartCoroutine(Event5());
        }
    }
}
