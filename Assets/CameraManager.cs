using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public void OnRootSelected(int id)
    {
        transform.GetChild(id).GetComponentInChildren<CinemachineVirtualCamera>().MoveToTopOfPrioritySubqueue();
    }

}
