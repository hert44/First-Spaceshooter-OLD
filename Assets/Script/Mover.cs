using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Rigidbody rigidbody; 
    public float speed;

    void Start() //Initiates on the first frame of the object initiation
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * speed;
    }

    void Render()
    {
        
    }
}
