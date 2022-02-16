using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    public GameObject canvas;
    private bool hasTouched;

    void Start()
    {
        hasTouched = false;
    }


    void Update()
    {
        if (Input.touchCount > 0)
        {
            hasTouched = true;
        }
        if (hasTouched)
        {
            canvas.SetActive(false);
        }
    }
}
