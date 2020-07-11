using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFollowPlayer : MonoBehaviour
{
    public Transform player;

    public Vector3 offset;
    public float smoothSpeed = 0.1f;

    private void FixedUpdate()      // Script for smooth camera motion
    {
        player = GameObject.FindWithTag("Player").transform;

        Vector3 desiredPosition = player.position + offset;    // deklarerar ny variabel som är lika med den position vi vill till. I detta fall mellan spelaren och middleground + offset

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);     // interpolerar mellan två värden
        transform.position = smoothedPosition;

        // transform.LookAt(player);
    }
}
