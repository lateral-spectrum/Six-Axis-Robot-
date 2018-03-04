using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RobotPose
{
    public string PoseName;

    public float BaseJointAngle;
    public float ShoulderJointAngle;
    public float ElbowJointAngle;
    public float FourthAxisJointAngle;
    public float FifthAxisJointAngle;
    public float SixthAxisJointAngle;

    public RobotPose(float base_joint_angle, float shoulder_joint_angle, float elbow_joint_angle, float fourth_axis_joint_angle, float fifth_axis_joint_angle, float sixth_axis_joint_angle)
    {
        this.BaseJointAngle = base_joint_angle;
        this.ShoulderJointAngle = shoulder_joint_angle;
        this.ElbowJointAngle = elbow_joint_angle;
        this.FourthAxisJointAngle = fourth_axis_joint_angle;
        this.FifthAxisJointAngle = fifth_axis_joint_angle;
        this.SixthAxisJointAngle = sixth_axis_joint_angle;
    }

}

public class RobotStateManager : MonoBehaviour {
    
    public JointMovementOperation ActiveOperation;
    public string StartPoseName; 

    
    public RobotPose[] PosePresets; 

    void Start()
    {
        RunRobotStartup(); 
    }

    void RunRobotStartup()
    {

    }

}
