using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] public class Boundary
{

    public float xMin, xMax, zMin, zMax;

}

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float tilt;
    public Boundary boundaryClass;
    public Rigidbody rigidbody;
    public AudioSource audio;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;
    //public static int playerShotCount = 0;  

    void Start ()
    {
        rigidbody = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        
        //SHOTS FUNCTION
        if(Input.GetButton("Fire1") && Time.time > nextFire/*&& playerShotCount < 2*/)
        {
            nextFire = Time.time + fireRate;
            //GameObject clone = 
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation); //as GameObject;
            audio.Play();
            //playerShotCount++;
        }
     
     }   

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0F, moveVertical/2);
        rigidbody.velocity = movement * speed;
        
        rigidbody.position = new Vector3
        (
            Mathf.Clamp(rigidbody.position.x, boundaryClass.xMin, boundaryClass.xMax),
            0.0F,
            Mathf.Clamp(rigidbody.position.z, boundaryClass.zMin, boundaryClass.zMax)
        );

        rigidbody.rotation = Quaternion.Euler (0.0F, 0.0F, rigidbody.velocity.x * -tilt);
    }
}