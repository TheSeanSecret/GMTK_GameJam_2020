using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndScreenScript : MonoBehaviour
{
    FMOD.Studio.Bus MasterBus;


    void Start()
    {
        MasterBus = FMODUnity.RuntimeManager.GetBus("Bus:/");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Application Quit");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            MasterBus.stopAllEvents(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);    // Stop All sounds before loading next Level
            SceneManager.LoadScene("StartMenu");
            Debug.Log("Start Menu Load");
        }
    }
}
