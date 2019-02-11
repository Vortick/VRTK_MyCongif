using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTimer : MonoBehaviour {

    public float timer;
    public bool unscaledTime = false;

    public UnityEvent OnFinished;

    Coroutine timerInstance;

    public void TimerStart()
    {
        timerInstance = StartCoroutine(TimerDelay(timer));
    }

    public void TimerStop()
    {
        if (timerInstance != null) StopCoroutine(timerInstance);
    }

    IEnumerator TimerDelay (float time)
    {
        if (unscaledTime) yield return new WaitForSecondsRealtime(time);
        else yield return new WaitForSeconds(time);
        OnFinished.Invoke();
    }
}
