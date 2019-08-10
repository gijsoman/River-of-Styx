using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Tappable : MonoBehaviour
{
    [SerializeField] UnityEvent OnTappedEvents;

    public void OnTapped() {
        //Test
        OnTappedEvents.Invoke();
    }
}
