using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour {
    
    public Transform target;
    
    public float smoothSpeed = 20F;
    public Vector3 offset;

    void FixedUpdate () {

        Vector3 desiredPosition = target.position/40 + offset;
        Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
        this.transform.position = smoothedPosition;

//ONLY FOR 3D - ADJUSTS THE CAMERA TO ALWAYS FOCUS ON THE PLAYER, FROM ANY VECTOR ANGLE.
        //transform.LookAt(target);
    }
    
}
