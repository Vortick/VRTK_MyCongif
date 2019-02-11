using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyBoardActions : MonoBehaviour {

	public QuickKeyBinding[] bindings;
	void Update () 
	{
		for(int i = 0; i < bindings.Length; i++)
		{
			bool pressed = false;
			for(int j = 0; j < bindings[i].keys.Length; j++)
			{
				if(Input.GetKeyDown(bindings[i].keys[j]))
					pressed = true;
			}
			if (pressed) bindings[i].OnKeyDown.Invoke();
		}
	}
}

[System.Serializable]
public class QuickKeyBinding
{
	public string[] keys;
	public UnityEvent OnKeyDown;
}
