using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class Player : MonoBehaviour
{

    [SerializeField] private IntVariableSO waterResource;
    [SerializeField] private IntVariableSO nutrientResource;
    [SerializeField] private IntVariableSO rootIndex;
    [SerializeField] private GameObject rootPrefab;

    List<Root> roots = new List<Root>();

    Root selectedRoot;

    public void Begin()
    {
        Instantiate(rootPrefab, transform).GetComponent<Root>();
        rootIndex.Value = 0;
    }

    public void Move(CallbackContext movement)
    {
        if (waterResource.Value > 0)
        {
            var movementVector = movement.ReadValue<Vector2>();
            selectedRoot.Move(movementVector);
            waterResource.Value--;
            if (movementVector.y < 0)
            {
                waterResource.Value--; //Costs extra water to move down
            }
        }
    }

    public void Split(CallbackContext context)
    {
        if (nutrientResource.Value >= 3)
        {
            selectedRoot.Split();
            nutrientResource.Value -= 3;
        }
    }

    public void SelectLeftRoot(CallbackContext context)
    {
        if (rootIndex.Value == 0)
        {
            rootIndex.Value = transform.childCount - 1;
        }
        else
        {
            rootIndex.Value--;
        }
        SetRoot(rootIndex.Value);
    }

    public void SelectRightRoot(CallbackContext context)
    {
        if (rootIndex.Value == transform.childCount - 1)
        {
            rootIndex.Value = 0;
        }
        else
        {
            rootIndex.Value++;
        }
        SetRoot(rootIndex.Value);
    }

    public void SetRoot(int index)
    {
        if (selectedRoot != null)
        {
            selectedRoot.Deselect();
        }
        selectedRoot = transform.GetChild(index).GetComponent<Root>();
        selectedRoot.Select();
    }

    public void ShouldGoLive(int state)
    {
        if (state == 0)
        {
            selectedRoot.GoLive();
        }
    }
}
