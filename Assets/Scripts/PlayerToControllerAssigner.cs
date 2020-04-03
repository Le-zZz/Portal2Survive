using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerToControllerAssigner : MonoBehaviour
{
    private List<int> assignedControllers = new List<int>();

    int controllerNmb = 2;
    private void Update()
    {
        for (int i = 1; i <= controllerNmb; i++)
        {
            if(assignedControllers.Contains(i))
            {
                continue;
            }
            if(Input.GetButton("J"+i+"A"))
            {
                AddPlayerController(i);
                break;
            }
        }
    }

    public Player AddPlayerController(int controller)
    {
        assignedControllers.Add(controller);
        return null;
    }
}
