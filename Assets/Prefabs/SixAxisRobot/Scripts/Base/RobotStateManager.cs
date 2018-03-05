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

    public RobotPose()
    {
        this.BaseJointAngle = 0f;
        this.ShoulderJointAngle = 0f;
        this.ElbowJointAngle = 0f;
        this.FourthAxisJointAngle = 0f;
        this.FifthAxisJointAngle = 0f;
        this.SixthAxisJointAngle = 0f;
    }

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
    public RobotPose ActiveRobotPose;
    public RobotPose[] PosePresets;

    RobotPose start_pos; 

    void Start()
    {
        RunRobotStartup(); 
    }

    void RunRobotStartup()
    {
        RobotPose start_pose = new RobotPose(0f, 0f, 0f, 0f, 0f, 0f); 

        JointMovementOperation move_to_start_pose = new JointMovementOperation(start_pos);
        ActiveOperation = move_to_start_pose;




        
    }


}
