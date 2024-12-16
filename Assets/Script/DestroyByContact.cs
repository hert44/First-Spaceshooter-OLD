using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{

    public GameObject explosion;
    public GameObject playerExplosion;

    void OnTriggerEnter(Collider other) 
    {

       if (other.tag == "Boundary") 
       {
           return; //Return to begining of function, don't continue to Destroy.
       }
       Instantiate(explosion, transform.position, transform.rotation);
       
       if (other.tag == "Player") 
       {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
       }

       Destroy(other.gameObject);
       /*if (other.gameObject == null)
       {
       PlayerController.playerShotCount--;
       }???????????????????????????????????????????????????????????????*/ 
       Destroy(gameObject);

    }
}
