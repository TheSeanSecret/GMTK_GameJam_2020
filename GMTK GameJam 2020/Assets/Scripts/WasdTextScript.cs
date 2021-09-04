using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WasdTextScript : MonoBehaviour
{
    public GameObject player;
    public Text WASD;
    public int  key;

    void Update() // Stupid sluggy code that does not work but I suck anyway so who cares
                    // Change letter of text to corresponding WASD key if
    {
        player = GameObject.FindWithTag("Player");

        if (player.GetComponent<PlayerMovementScript>().wasdKeys.IndexOf("W").Equals(key))
        {
            WASD.text = ("W");
        }

        if (player.GetComponent<PlayerMovementScript>().wasdKeys.IndexOf("A").Equals(key))
        {
            WASD.text = ("A");
        }

        if (player.GetComponent<PlayerMovementScript>().wasdKeys.IndexOf("S").Equals(key))
        {
            WASD.text = ("S");
        }
        if (player.GetComponent<PlayerMovementScript>().wasdKeys.IndexOf("D").Equals(key))
        {
            WASD.text = ("D");
        }
    }
}