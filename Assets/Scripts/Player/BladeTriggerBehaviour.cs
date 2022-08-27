using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BladeTriggerBehaviour : MonoBehaviour
{
    private OnTriggerEnterEvent onTriggerEnterEvent = new OnTriggerEnterEvent();


    private void OnTriggerEnter(Collider other)
    {
        onTriggerEnterEvent.Invoke();
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
        onTriggerEnterEvent.RemoveAllListeners();
    }

    public OnTriggerEnterEvent GetOnCollisionEnterEvent()
    {
        return onTriggerEnterEvent;
    }
}

[System.Serializable]
public class OnTriggerEnterEvent : UnityEvent { }
