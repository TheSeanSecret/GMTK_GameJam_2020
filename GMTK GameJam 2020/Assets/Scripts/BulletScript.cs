using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody rb;
    public float destroyTime = 3;
    public GameObject explosion;


    void Start()
    {
        rb.velocity = transform.forward * speed;        // Fart framåt
        Invoke("DestroyObject", destroyTime);           // Bullet lifetime timer

    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall") // if bullet hits player then make new player, destroy bullet and destroy player
        {
            Instantiate(explosion, transform.position, transform.rotation);      
            Destroy(gameObject);
        }
    }
}
