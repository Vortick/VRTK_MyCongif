using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartEvent : MonoBehaviour {

    public UnityEvent OnStarted;

    private void Start()
    {
        //Debug.Log("Start Event from: " + transform.name);
        OnStarted.Invoke();
    }
}
