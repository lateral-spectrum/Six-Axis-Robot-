using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour {

    public Camera Camera;
    Transform camera_transform; 

    void Update()
    {
        gameObject.transform.LookAt(camera_transform); 
    }
}
