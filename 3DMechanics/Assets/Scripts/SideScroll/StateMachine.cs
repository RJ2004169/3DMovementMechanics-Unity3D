using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{

    private States currentState;

    public void SetState( States newState)
    {
        currentState = newState;
        StartCoroutine(currentState.Start());
    }
    private void Start()
    {

    }
}
