using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool controllerPauseState = false;
    private bool lockAndHideCursor = true;

    void Start()
    {
        Cursor.visible = false;
    }

 
    void Update()
    {
        if (Input.GetButtonDown("Cancel")) //game pause
        {
            ControllerPause();
            Debug.Log($"pause state: {controllerPauseState}, lockState: {lockAndHideCursor}");
        }
    }
    public void ControllerPause()
    {
        controllerPauseState = !controllerPauseState;
        if (lockAndHideCursor)
        {
            Cursor.lockState = controllerPauseState ? CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = controllerPauseState;
        }
    }
}
