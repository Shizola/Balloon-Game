using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimator : MonoBehaviour
{
    public Animator handAnimator;
    public InputActionReference trigger;
    public InputActionReference grip;

    public bool posing;

    // Update is called once per frame
    void Update()
    {
        handAnimator.SetFloat("Trigger", trigger.action.ReadValue<float>());
        handAnimator.SetFloat("Grip", grip.action.ReadValue<float>());
    }

    public void AnimateHandPose(string animationName)
    {
        handAnimator.Play(animationName);
    }

    public void PlayDefaultHandAnimation()
    {
        handAnimator.Play("Default");
    }
}
