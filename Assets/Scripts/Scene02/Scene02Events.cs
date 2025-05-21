using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEngine.UI;
public class Scene02EventScript : MonoBehaviour
{
    public GameObject fadeSceenIn;
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
    [SerializeField] GameObject demonInteract;
    [SerializeField] GameObject demon1Interact;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(EventStarter());
    }

    // Update is called once per frame
    void Update()
    {
        textLength = TextCreator.charCount;
    }

    IEnumerator EventStarter()
    {
        // event 0
        yield return new WaitForSeconds(2);
        fadeSceenIn.SetActive(false);
        charIsabelleSerious.SetActive(true);
        yield return new WaitForSeconds(2);
        // text function added here.
        mainTextObject.SetActive(true);
        //charName.GetComponent<TMPro.TMP_Text>().text = "Isabelle";
        textToSpeak = "Where are these animal crossing noises intensifies";
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
        textToSpeak = "Incoming from the sky!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak; //Transfers to gameobject
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(.05f);
        nextButton.SetActive(true); 
        eventPos = 2;
    }

    IEnumerator Event2()
    {
        nextButton.SetActive(false);
        charDoomGuy.SetActive(false);
        charIsabelleSerious.SetActive(false);
        mainTextObject.SetActive(false);
        demonInteract.SetActive(true);
        yield return new WaitForSeconds(1);
        demon1Interact.SetActive(true);
        eventPos = 3;
    }
    IEnumerator DemonInteractSeq()
    {
        demonInteract.SetActive(false);
        yield return new WaitForSeconds(1);
        eventPos = 4;
    }
    IEnumerator Demon1InteractSeq()
    {
        demon1Interact.SetActive(false);
        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 5;
    }

    IEnumerator Event3()
    {
        nextButton.SetActive(false);
        charDoomGuy.SetActive(true);
        charIsabelleSerious.SetActive(true);
        textBox.SetActive(true);
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "DoomGuy";
        textToSpeak = "Serves them right let's head back";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak; //Transfers to gameobject
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(.05f);
        fadeOut.SetActive(true);
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
        if (eventPos == 5)
        {
            StartCoroutine(Event3());
        }
    }

    public void DemonInteract()
    {
        if (eventPos == 3)
        {
            StartCoroutine(DemonInteractSeq());
        }
    }
    public void Demon1Interact()
    {
        if (eventPos == 4)
        {
            StartCoroutine(Demon1InteractSeq());
        }
    }
}
