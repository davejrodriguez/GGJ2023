using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCamController : MonoBehaviour
{
    CinemachineVirtualCamera cam;

    private void Awake()
    {
        cam= GetComponent<CinemachineVirtualCamera>();
    }

    public void ShouldGoLive(int state)
    {
        if (state == 1)
        {
            cam.MoveToTopOfPrioritySubqueue();
        }
    }

}
