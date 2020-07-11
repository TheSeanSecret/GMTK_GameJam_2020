using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Transform groundMiddle;

    public Vector3 offset;
    public float smoothSpeed = 0.1f;


    void Start()
    {
        
    }


    // Script for smooth camera motion - 
    private void FixedUpdate()
    {

        player = GameObject.FindWithTag("Player").transform;
        groundMiddle = GameObject.FindWithTag("GroundMiddle").transform;


        // deklarerar ny variabel som är lika med den position vi vill till
        Vector3 desiredPosition = (player.position + groundMiddle.position).normalized + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

         // Make camera look at player
     // transform.LookAt(player);
    }





    // Thx Brackey, yur awesome
}
