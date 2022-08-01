using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFOllow : MonoBehaviour
{
    

 public Transform Player;
 int MoveSpeed = 4;
 int MaxDist = 100;
 int MinDist = 0;
 
 GameObject Trump;
 
 
void Start () 
 {
     Trump=GameObject.Find("Trump");
     Player=Trump.GetComponent<Transform>();
 }
 
void Update () 
 {
     transform.LookAt(Player);
     
     if(Vector3.Distance(transform.position,Player.position) >= MinDist){
     
          transform.position += transform.forward*MoveSpeed*Time.deltaTime;
 
           
           
          if(Vector3.Distance(transform.position,Player.position) <= MaxDist)
              {
                 //Here Call any function U want Like Shoot at here or something
              } 
    
    }
 }


   private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Finish")
        {
            Trump.GetComponent<scoreHandler>().scoreUpdate();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag=="Player")
        {
            Trump.GetComponent<scoreHandler>().InfectionUpdate();
            Destroy(this.gameObject);
        }
    }




}
