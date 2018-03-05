using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// use this class to modify the position of the robot. 

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

    }

    //public void SetBaseAngle(float target_angle, float velocity)
    //{
    //    unlockJoint(BaseJoint);  
    //}

    //public void SetShoulderAngle(float target_angle, float velocity)
    //{
    //    unlockJoint(ShoulderJoint); 
    //}

    //public IEnumerator SetElbowAngle(float target_angle, float velocity)
    //{
    //    unlockJoint(ShoulderJoint);

    //    yield return new WaitForSeconds(); 
    //}

    //public void SetFourthAxisAngle(float target_angle, float velocity)
    //{
    //    if (FourthAxisJoint.useSpring)
    //    {

    //    }
    //    else if (FourthAxisJoint.useMotor)
    //    {

    //    }
    //}

    //public void SetFifthAxisAngle(float target_angle, float velocity)
    //{
    //    if (FifthAxisJoint.useSpring)
    //    {

    //    }
    //    else if (FifthAxisJoint.useMotor)
    //    {

    //    }
    //}

    //public void SetSixthAxisAngle(float target_angle, float velocity)
    //{
    //    if (SixthAxisJoint.useSpring)
    //    {

    //    }
    //    else if (SixthAxisJoint.useMotor)
    //    {

    //    }
    //}
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
