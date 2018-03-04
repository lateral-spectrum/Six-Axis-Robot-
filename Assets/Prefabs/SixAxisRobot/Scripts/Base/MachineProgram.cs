using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineProgram {

    public JointMovementOperation[] program_steps; 

    public MachineProgram (JointMovementOperation[] steps)
    {

    }

    public void RunProgram()
    {
        for (int i = 0; i < program_steps.Length; i++)
        {
            program_steps[i].RunOperation(); 
        }
    }
}
