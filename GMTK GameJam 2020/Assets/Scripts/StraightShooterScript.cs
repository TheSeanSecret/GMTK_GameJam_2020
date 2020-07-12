using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightShooterScript : MonoBehaviour
{
    public GameObject bullet;
    public Transform muzzle;

    public float fireRate = 0.5F;
    private float nextFire = 0.0F;

    void Update()
    {
        

        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, muzzle.position, muzzle.rotation);      // Instansierar enemy bullet muzzle med mellanrum
        }
    }
}
