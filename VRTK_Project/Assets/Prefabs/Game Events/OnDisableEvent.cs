using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnDisableEvent : MonoBehaviour {

	public UnityEvent OnDisabled;

	private void OnDisable()
	{
		OnDisabled.Invoke();
	}
}
