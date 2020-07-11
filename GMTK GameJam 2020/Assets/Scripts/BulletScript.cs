using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody rb;
    public float destroyTime = 3;

    void Start()
    {
        rb.velocity = transform.forward * speed;
        Invoke("DestroyObject", destroyTime);

    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
