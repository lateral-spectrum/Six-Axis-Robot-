using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisControl : MonoBehaviour {

    public HingeJoint BaseJoint;
    public HingeJoint ShoulderJoint;
    public HingeJoint ElbowJoint;
    public HingeJoint FourthAxisJoint;
    public HingeJoint FifthAxisJoint;
    public HingeJoint SixthAxisJoint;
    
    // spring should be used to hold in place, motor should be used to get to the angle 


    public void SetBaseAngle(float target_angle, float velocity)
    {
        if (BaseJoint.useSpring)
        {

        }
        else if (BaseJoint.useMotor)
        {

        }        
    }

    public void SetShoulderAngle(float target_angle, float velocity)
    {
        if (ShoulderJoint.useSpring)
        {

        }
        else if (ShoulderJoint.useSpring)
        {

        }
    }

    public void SetElbowAngle(float target_angle, float velocity)
    {
        if (ElbowJoint.useSpring)
        {

        }
        else if (ElbowJoint.useMotor)
        {

        }
    }

    public void SetFourthAxisAngle(float target_angle, float velocity)
    {
        if (FourthAxisJoint.useSpring)
        {

        }
        else if (FourthAxisJoint.useMotor)
        {

        }
    }

    public void SetFifthAxisAngle(float target_angle, float velocity)
    {
        if (FifthAxisJoint.useSpring)
        {

        }
        else if (FifthAxisJoint.useMotor)
        {

        }
    }

    public void SetSixthAxisAngle(float target_angle, float velocity)
    {
        if (SixthAxisJoint.useSpring)
        {

        }
        else if (SixthAxisJoint.useMotor)
        {

        }
    }
    // maybe can use only motor joints if target velocity is not zero? 
    void lockJoint(HingeJoint joint) // called after each motor movement to maintain position, create another meothd to reduce vel to 0 smoothly 
    {
        joint.useMotor = false;
        joint.useSpring = true; 
    }

    void unlockJoint(HingeJoint joint)
    {
        joint.useSpring = false;
        joint.useMotor = true; 
    }
}
