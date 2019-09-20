using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    private void Awake()
    {

    }

    void Start()
    {
        TKPanRecognizer gesture = new TKPanRecognizer(0);
        gesture.gestureRecognizedEvent += OnPan;
        gesture.gestureCompleteEvent += OnPanComplete;
        TouchKit.addGestureRecognizer(gesture);
    }

    void Update()
    {

    }

    private void OnDestroy()
    {
        TouchKit.removeAllGestureRecognizers();
    }

    public void OnPan(TKPanRecognizer recognizer)
    {

    }

    public void OnPanComplete(TKPanRecognizer recognizer)
    {
       
    }
}
