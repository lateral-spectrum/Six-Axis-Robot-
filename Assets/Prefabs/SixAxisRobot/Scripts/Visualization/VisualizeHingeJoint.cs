using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizeHingeJoint : MonoBehaviour {

    HingeJoint VisualizedJoint; 
    
    public void Start()
    {

    }

    void Update()
    {

    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;

        Vector3 anchor_pos = VisualizedJoint.anchor; 

            
    }
}
