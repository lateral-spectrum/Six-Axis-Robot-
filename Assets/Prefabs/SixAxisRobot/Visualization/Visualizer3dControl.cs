using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Visualizer3dControl : MonoBehaviour {    

    public GameObject Visualizer3dPrefab;    
    public Vector3 PositionOffset;
    public Camera Camera;

    HingeJoint joint; 
    GameObject visualizer_3d;

    Vector3 joint_position;     
    
    
    void Start()
    {
        joint = GetComponent<HingeJoint>(); 
        visualizer_3d = Instantiate(Visualizer3dPrefab, getVisualizerPosition(), new Quaternion()); 
    }

    void Update()
    {
        visualizer_3d.transform.LookAt(Camera.transform);
        visualizer_3d.transform.position = getVisualizerPosition();

        float hinge_joint_angle = joint.angle;

        GameObject text_component = visualizer_3d.transform.GetChild(1).gameObject;
        text_component.GetComponent<TextMesh>().text = "Angle: " + Mathf.RoundToInt(hinge_joint_angle); 
    }    

    Vector3 getVisualizerPosition()
    {
        Vector3 pos = joint.transform.position;
        pos.x += PositionOffset.x;
        pos.y += PositionOffset.y;
        pos.z += PositionOffset.z;
        return pos; 
    }

}
