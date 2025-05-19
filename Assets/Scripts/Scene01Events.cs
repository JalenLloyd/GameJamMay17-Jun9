using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Scene01Events : MonoBehaviour
{

    public GameObject fadeSceenIn;
    public GameObject charIsabelleThink; //Placeholder
    public GameObject charIsabelleGreet; //Placeholder
    public GameObject charDoomGuy; //Placeholder
    public GameObject textBox;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        yield return new WaitForSeconds(2);
        fadeSceenIn.SetActive(false);
        charIsabelleGreet.SetActive(false);
        charIsabelleThink.SetActive(true);
        yield return new WaitForSeconds(2);
        // text function added here.
        textBox.SetActive(true);
        yield return new WaitForSeconds(2);
        charDoomGuy.SetActive(true);
    }
}
