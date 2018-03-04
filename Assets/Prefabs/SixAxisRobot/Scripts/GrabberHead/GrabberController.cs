using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabberController : MonoBehaviour {

    public bool GrabberIsOpen;
    public float GrabberOpenAngle;
    public float GrabberClosedAngle;

    public HingeJoint[] ClawJointsRight;
    public HingeJoint[] ClawJointsLeft;     
    
    public 

    void FixedUpdate()
    {
        if (GrabberIsOpen)
        {
            // check not send continuous ? 
            OpenGrabber(); 
        }
        else
        {            
            CloseGrabber(); 
        }
    }

    

    public void OpenGrabber()
    {
        foreach (HingeJoint joint in ClawJointsRight)
        {
            JointSpring spring = joint.spring;
            spring.targetPosition = GrabberOpenAngle;
            joint.spring = spring; 
        }
        foreach (HingeJoint joint in ClawJointsLeft)
        {
            JointSpring spring = joint.spring;
            spring.targetPosition = GrabberOpenAngle;
            joint.spring = spring; 
        }
    }

    public void CloseGrabber()
    {
        foreach (HingeJoint joint in ClawJointsRight)
        {
            JointSpring spring = joint.spring;
            spring.targetPosition = GrabberClosedAngle;
            joint.spring = spring; 
        }
        foreach (HingeJoint joint in ClawJointsLeft)
        {
            JointSpring spring = joint.spring;
            spring.targetPosition = GrabberClosedAngle; 
            joint.spring = spring;
        }
    }


}
