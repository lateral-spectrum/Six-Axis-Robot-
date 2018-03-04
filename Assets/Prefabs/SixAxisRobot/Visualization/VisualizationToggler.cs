using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizationToggler : MonoBehaviour {

    GameObject[] visualizers = new GameObject[0];   

    void Update()
    {
        if (visualizers.Length < 1)
        {
            visualizers = GameObject.FindGameObjectsWithTag("Visualizer3d");
            print("Got " + visualizers.Length + " visualizers in scene.");
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            toggleVisualizers(); 
        }
    }

    void toggleVisualizers()
    {
        print("Toggling visualizers."); 
        foreach (GameObject ob in visualizers)
        {
            
            ob.SetActive(!ob.activeInHierarchy);
        }
    }  
}
