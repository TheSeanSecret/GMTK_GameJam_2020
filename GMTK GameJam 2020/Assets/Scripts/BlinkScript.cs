using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkScript : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public Collider colliderBox;

    public float fireRate = 1F;
    private float nextFire = 0.0F;

    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GetComponent<MeshRenderer>().enabled = true;    
        }
        else if(Time.time < nextFire)
        {
            GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
