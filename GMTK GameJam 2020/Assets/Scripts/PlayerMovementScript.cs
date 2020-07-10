using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementScript : MonoBehaviour
{
    Vector3 
        up = Vector3.zero,
        right = new Vector3(0, 90, 0),
        down = new Vector3(0, 180, 0),
        left = new Vector3(0, 270, 0),
        currentDirection = Vector3.zero;

    Vector3 nextPos, destination, direction;

    public float speed = 5f;
    float rayLength = 1f;

    bool canMove;

    Vector3 startPosition;  // GameObject current position at start is the start position

    /* class KeyDirection
     {
         public KeyDirection(string W, string A, string S, string D)
         {
             List<string> keyDir = new List<string>(W = "W",A = "A",S = "S",D = "D");
         }
     } */

    public string[] wasdKeys = new string[] { "W", "A", "S", "D" };


    void Start()
    {
        currentDirection = up;
        nextPos = Vector3.forward;
        destination = transform.position;

        startPosition = transform.position;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);




        if (Input.GetKeyDown(KeyCode.W))
        {
            nextPos = Vector3.forward;
            currentDirection = up;
            canMove = true;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            nextPos = Vector3.back;
            currentDirection = down;
            canMove = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            nextPos = Vector3.right;
            currentDirection = right;
            canMove = true;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            nextPos = Vector3.left;
            currentDirection = left;
            canMove = true;
        }

        if (Vector3.Distance(destination, transform.position) <= 0.1f)
        {
            transform.localEulerAngles = currentDirection;   // Rotation

            if (canMove)   // Movement
            {
                if (Valid())
                {
                    destination = transform.position + nextPos;
                    direction = nextPos;
                    canMove = false;
                }
            }
        }


    }

    bool Valid()
    {
        Ray myRay = new Ray(transform.position + new Vector3(0, 0.2f, 0), transform.forward);
        RaycastHit hit;

        Debug.DrawRay(myRay.origin, myRay.direction, Color.cyan);

        if(Physics.Raycast(myRay,out hit,rayLength))
        {
            if(hit.collider.tag == "Wall")
            {
                // transform.position = startPosition;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Restart Level
                // return false;
            }

            if (hit.collider.tag == "Boundary") // cannot move if hit level boundary
            {
                return false;
            }
        }
        return true;
    }
}
