using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotRawController : MonoBehaviour
{   
    public HingeJoint BaseJoint;
    public HingeJoint ShoulderJoint;
    public HingeJoint ElbowJoint;
    public HingeJoint FourthAxisJoint;
    public HingeJoint FifthAxisJoint; 
    public HingeJoint SixthAxisJoint;

    public bool BaseJointUseMotor;
    public bool ShoulderJointUseMotor;
    public bool ElbowJointUseMotor;
    public bool FourthAxisJointUseMotor;
    public bool FifthAxisJointUseMotor;
    public bool SixthAxisJointUseMotor;

    public float BaseJointMotorTargetVelocity;
    public float ShoulderJointMotorTargetVelocity;
    public float ElbowJointMotorTargetVelocity;
    public float FourthAxisJointMotorTargetVelocity;
    public float FifthAxisJointMotorTargetVelocity;
    public float SixthAxisJointMotorTargetVelocity;

    public float BaseJointMotorForce;
    public float ShoulderJointMotorForce;
    public float ElbowJointMotorForce;
    public float FourthAxisJointMotorForce;
    public float FifthAxisJointMotorForce;
    public float SixthAxisJointMotorForce; 

    public bool BaseJointUseSpring;
    public bool ShoulderJointUseSpring;
    public bool ElbowJointUseSpring;
    public bool FourthAxisJointUseSpring;
    public bool FifthAxisJointUseSpring;
    public bool SixthAxisJointUseSpring;   

    public float BaseJointSpringForce;
    public float ShoulderJointSpringForce;
    public float ElbowJointSpringForce;
    public float FourthAxisJointSpringForce;
    public float FifthAxisJointSpringForce;
    public float SixthAxisJointSpringForce;

    public float BaseJointSpringDamper;
    public float ShoulderJointSpringDamper;
    public float ElbowJointSpringDamper;
    public float FourthAxisJointSpringDamper;
    public float FifthAxisJointSpringDamper;
    public float SixthAxisJointSpringDamper;

    public float BaseJointSpringTargetPosition;
    public float ShoulderJointSpringTargetPosition;
    public float ElbowJointSpringTargetPosition;
    public float FourthAxisJointSpringTargetPosition;
    public float FifthAxisJointSpringTargetPosition; 
    public float SixthAxisJointSpringTargetPosition;

    public bool BaseJointUseLimits;
    public bool ShoulderJointUseLimits;
    public bool ElbowJointUseLimits;
    public bool FourthAxisJointUseLimits;
    public bool FifthAxisJointUseLimits;
    public bool SixthAxisJointUseLimits;

    public float BaseJointLimitsMinimum; 
    public float BaseJointLimitsMaximum;
    public float ShoulderJointLimitsMinimum; 
    public float ShoulderJointLimitsMaximum;
    public float ElbowJointLimitsMinimum; 
    public float ElbowJointLimitsMaximum;
    public float FourthAxisLimitsMinimum; 
    public float FourthAxisLimitsMaximum;
    public float FifthAxisLimtsMinimum;
    public float FifthAxisLimtsMaximum;
    public float SixthAxisLimitsMinimum;
    public float SixthAxisLimitsMaximum;

    public float BaseJointLimitsBounciness;
    public float ShoulderJointLimitsBounciness;
    public float ElbowJointLimitsBounciness;
    public float FourthAxisJointLimitsBounciness;
    public float FifthAxisJointLimitsBounciness;
    public float SixthAxisJointLimitsBounciness;

    public float BaseJointLimitsBounceMinVelocity;
    public float ShoulderJointLimitsBounceMinVelocity;
    public float ElbowJointLimitsBounceMinVelocity;
    public float FourthAxisJointLimitsBounceMinVelocity;
    public float FifthAxisJointLimitsBounceMinVelocity;
    public float SixthAxisJointLimitsBounceMinVelocity;

    public float BaseJointLimitsContactDistance;
    public float ShoulderJointLimitsContactDistance;
    public float ElbowJointLimitsContactDistance;
    public float FourthAxisJointLimitsContactDistance;
    public float FifthAxisJointLimitsContactDistance; 
    public float SixthAxisJointLimitsContactDistance; 

    public float BaseJointAngleTolerance;
    public float ShoulderJointAngleTolerance;
    public float ElbowJointAngleTolerance;
    public float FourthAxisJointAngleTolerance;
    public float FifthAxisJointAngleTolerance;
    public float SixthAxisJointAngleTolerance; 

    void FixedUpdate()
    {
        WriteJointDataToRobot(); 
    }

    void WriteJointDataToRobot()
    {
        JointMotor motor; 
        JointSpring spring;
        var limits = BaseJoint.limits; 

        BaseJoint.useMotor = BaseJointUseMotor;
        motor = BaseJoint.motor;
        motor.force = BaseJointMotorForce;
        motor.targetVelocity = BaseJointMotorTargetVelocity;
        BaseJoint.motor = motor;
        BaseJoint.useLimits = BaseJointUseLimits; 
        limits = BaseJoint.limits;
        limits.min = BaseJointLimitsMinimum;
        limits.max = BaseJointLimitsMaximum;
        limits.bounciness = BaseJointLimitsBounciness;
        limits.bounceMinVelocity = BaseJointLimitsBounceMinVelocity; 
        limits.contactDistance = BaseJointLimitsContactDistance; 
        BaseJoint.limits = limits;        
        BaseJoint.useSpring = BaseJointUseSpring;
        spring = BaseJoint.spring;
        spring.targetPosition = BaseJointSpringTargetPosition;
        spring.spring = BaseJointSpringForce;
        spring.damper = BaseJointSpringDamper;
        BaseJoint.spring = spring;

        ShoulderJoint.useMotor = ShoulderJointUseMotor;
        motor = ShoulderJoint.motor;
        motor.force = ShoulderJointMotorForce;
        motor.targetVelocity = ShoulderJointMotorTargetVelocity;
        ShoulderJoint.motor = motor;
        ShoulderJoint.limits = limits;
        ShoulderJoint.useLimits = ShoulderJointUseLimits;
        limits = ShoulderJoint.limits;
        limits.min = ShoulderJointLimitsMinimum;
        limits.max = ShoulderJointLimitsMaximum;
        limits.bounciness = ShoulderJointLimitsBounciness;
        limits.bounceMinVelocity = ShoulderJointLimitsBounceMinVelocity;
        limits.contactDistance = ShoulderJointLimitsContactDistance;        
        ShoulderJoint.useSpring = ShoulderJointUseSpring;
        spring = ShoulderJoint.spring;
        spring.targetPosition = ShoulderJointSpringTargetPosition;
        spring.spring = ShoulderJointSpringForce;
        spring.damper = ShoulderJointSpringDamper;
        ShoulderJoint.spring = spring;

        ElbowJoint.useMotor = ElbowJointUseMotor;
        motor = ElbowJoint.motor;
        motor.force = ElbowJointMotorForce;
        motor.targetVelocity = ElbowJointMotorTargetVelocity;
        ElbowJoint.motor = motor;
        ElbowJoint.useLimits = ElbowJointUseLimits;
        limits = ElbowJoint.limits;
        limits.min = ElbowJointLimitsMinimum;
        limits.max = ElbowJointLimitsMaximum;
        limits.bounciness = ElbowJointLimitsBounciness;
        limits.bounceMinVelocity = ElbowJointLimitsBounceMinVelocity;
        limits.contactDistance = ElbowJointLimitsContactDistance;
        ElbowJoint.limits = limits;
        ElbowJoint.useSpring = ElbowJointUseSpring;
        spring = ElbowJoint.spring;
        spring.targetPosition = ElbowJointSpringTargetPosition;
        spring.spring = ElbowJointSpringForce;
        spring.damper = ElbowJointSpringDamper;
        ElbowJoint.spring = spring;

        FourthAxisJoint.useMotor = FourthAxisJointUseMotor;
        motor = FourthAxisJoint.motor;
        motor.force = FourthAxisJointMotorForce;
        motor.targetVelocity = FourthAxisJointMotorTargetVelocity;
        FourthAxisJoint.motor = motor;
        FourthAxisJoint.useLimits = FourthAxisJointUseLimits;
        limits = FourthAxisJoint.limits;
        limits.min = FourthAxisLimitsMinimum;
        limits.max = FourthAxisLimitsMaximum;
        limits.bounciness = FourthAxisJointLimitsBounciness;
        limits.bounceMinVelocity = FourthAxisJointLimitsBounceMinVelocity;
        limits.contactDistance = FourthAxisJointLimitsContactDistance;
        FourthAxisJoint.limits = limits;
        FourthAxisJoint.useSpring = FourthAxisJointUseSpring;
        spring = FourthAxisJoint.spring;
        spring.targetPosition = FourthAxisJointSpringTargetPosition;
        spring.spring = FourthAxisJointSpringForce;
        spring.damper = FourthAxisJointSpringDamper;
        FourthAxisJoint.spring = spring;


        FifthAxisJoint.useMotor = FifthAxisJointUseMotor;
        motor = FifthAxisJoint.motor;
        motor.force = FifthAxisJointMotorForce;
        motor.targetVelocity = FifthAxisJointMotorTargetVelocity;
        FifthAxisJoint.motor = motor;
        FifthAxisJoint.useLimits = FifthAxisJointUseLimits;
        limits = FifthAxisJoint.limits;
        limits.min = FifthAxisLimtsMinimum;
        limits.max = FifthAxisLimtsMaximum;
        limits.bounciness = FifthAxisJointLimitsBounciness;
        limits.bounceMinVelocity = FifthAxisJointLimitsBounceMinVelocity;
        limits.contactDistance = FifthAxisJointLimitsContactDistance;
        FifthAxisJoint.limits = limits;
        FifthAxisJoint.useSpring = FifthAxisJointUseSpring;
        spring = FifthAxisJoint.spring;
        spring.targetPosition = FifthAxisJointSpringTargetPosition;
        spring.spring = FifthAxisJointSpringForce;
        spring.damper = FifthAxisJointSpringDamper;
        FifthAxisJoint.spring = spring;


        SixthAxisJoint.useMotor = SixthAxisJointUseMotor;
        motor = SixthAxisJoint.motor;
        motor.force = SixthAxisJointMotorForce;
        motor.targetVelocity = SixthAxisJointMotorTargetVelocity;
        SixthAxisJoint.motor = motor;
        SixthAxisJoint.useLimits = SixthAxisJointUseLimits;
        limits = SixthAxisJoint.limits;
        limits.min = SixthAxisLimitsMinimum;
        limits.max = SixthAxisLimitsMaximum; 
        limits.bounciness = SixthAxisJointLimitsBounciness;
        limits.bounceMinVelocity = SixthAxisJointLimitsBounceMinVelocity;
        limits.contactDistance = SixthAxisJointLimitsContactDistance;
        SixthAxisJoint.limits = limits;
        SixthAxisJoint.useSpring = SixthAxisJointUseSpring;
        spring = SixthAxisJoint.spring;
        spring.targetPosition = SixthAxisJointSpringTargetPosition;
        spring.spring = SixthAxisJointSpringForce;
        spring.damper = SixthAxisJointSpringDamper;
        SixthAxisJoint.spring = spring;        
        
    }    

    // CREATE Option and methods to steady the robot in joint moves? move in to strict stable mode? better. 
}
