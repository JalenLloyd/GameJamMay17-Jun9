using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Scene02EventScript : MonoBehaviour
{
    public GameObject fadeSceenIn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(EventStarter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EventStarter()
    {
        // event 0
        yield return new WaitForSeconds(2);
        fadeSceenIn.SetActive(false);
    }
}
