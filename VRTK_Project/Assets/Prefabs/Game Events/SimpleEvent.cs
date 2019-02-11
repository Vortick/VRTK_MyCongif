using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleEvent : MonoBehaviour {

	public UnityEvent OnInvoke;

	public void InvokeEvent()
	{
		OnInvoke.Invoke();
	}
}
