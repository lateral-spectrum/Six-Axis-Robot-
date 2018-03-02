using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabberKeyBoardInputController : MonoBehaviour {

    public GameObject Grabber;

    GrabberController grabber_controller; 

    void Start()
    {
        grabber_controller = Grabber.GetComponent<GrabberController>(); 
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            grabber_controller.GrabberIsOpen = !grabber_controller.GrabberIsOpen;
        }
    }
}
