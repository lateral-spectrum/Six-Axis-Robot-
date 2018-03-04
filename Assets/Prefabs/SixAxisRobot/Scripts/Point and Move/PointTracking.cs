using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTracking : MonoBehaviour {

    public Vector3 WorldPointHovered = new Vector3();
    public Vector3 WorldPointClicked; 

	void Update()
    {
        SetScreenWorldPoint(ref WorldPointHovered); 

        if (Input.GetMouseButtonDown(0))
        {
            SetScreenWorldPoint(ref WorldPointClicked); 
        }    
    }

    void SetScreenWorldPoint(ref Vector3 point)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit; 

        if (Physics.Raycast (ray, out hit))
        {
            point = hit.point;
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        
        Gizmos.DrawSphere(WorldPointHovered, 0.5f); 

        if (WorldPointClicked != null)
        {
            Gizmos.color = Color.blue; 
            Gizmos.DrawSphere(WorldPointClicked, 1f); 
        }
    }
}
