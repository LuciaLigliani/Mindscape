using Inworld;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PushToTalk : MonoBehaviour
{
    public InputActionReference pttRef = null;

    // Start is called before the first frame update
    void Start()
    {
        InworldController.Audio.IsBlocked = true;
        pttRef.action.started += PttStarted;
        pttRef.action.canceled += PttReleased;
    }

    private void PttStarted(InputAction.CallbackContext context)
    {
        InworldController.Audio.IsBlocked = false;
        //InworldController.Instance.StartAudio();
        Debug.Log("Primary button pressed");
    }

    private void PttReleased(InputAction.CallbackContext context)
    {
        InworldController.Audio.IsBlocked = true;
        //InworldController.Instance.PushAudio();
        Debug.Log("Primary button released");
    }

}
