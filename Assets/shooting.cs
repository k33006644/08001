using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
     public float bulletSpeed = 10;
     public Transform nozzle;
     public Rigidbody bullet;
     public scoreHandler scoreHandler;
     
     public void Fire()
     {
         scoreHandler.spraySound();
         Rigidbody bulletClone = (Rigidbody) Instantiate(bullet,nozzle.position, Quaternion.identity);
         bulletClone.velocity = transform.forward * bulletSpeed;
     }
 
     void Update () 
     {
         //if (Input.GetButtonDown("Fire1"))
          //   Fire();
     }
}
