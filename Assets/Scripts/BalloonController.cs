using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BalloonController : MonoBehaviour
{
    public Balloon[] balloons;
    
    public UnityEvent onBalloonsPopped;

    bool allPopped;

    void Update()
    {
        if(!allPopped)
        {
            allPopped = true;

            for (int i = 0; i < balloons.Length; i++)
            {
                if (balloons[i].hasPopped == false)
                    allPopped = false;
            }

            if (allPopped)
                onBalloonsPopped.Invoke();
        }     
    }

    public void StartQuit()
    {
        StartCoroutine(Quit());
    }

    private IEnumerator Quit()
    {
        yield return new WaitForSeconds(30);
        Application.Quit();
    }
}
