using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Transform groundMiddle;

    public Vector3 offset;
    public float smoothSpeed = 0.1f;

    private void FixedUpdate()      // Script for smooth camera motion
    {
        player = GameObject.FindWithTag("Player").transform;
        groundMiddle = GameObject.FindWithTag("GroundMiddle").transform;

        Vector3 desiredPosition = (player.position + groundMiddle.position).normalized + offset;    // deklarerar ny variabel som är lika med den position vi vill till. I detta fall mellan spelaren och middleground + offset

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);     // interpolerar mellan två värden
        transform.position = smoothedPosition;

     // transform.LookAt(player);
    }

}
