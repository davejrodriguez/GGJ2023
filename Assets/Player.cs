using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class Player : MonoBehaviour
{

    [SerializeField] private VariableSO<int> waterResource;
    [SerializeField] private VariableSO<int> rootIndex;
    [SerializeField] private GameObject rootPrefab;

    List<Root> roots = new List<Root>();

    Root selectedRoot;

    private void Start()
    {
        Instantiate(rootPrefab, transform).GetComponent<Root>();
        rootIndex.Value = 0;
    }

    public void Move(CallbackContext movement)
    {
        if (waterResource.Value > 0)
        {
            transform.GetChild(rootIndex.Value).GetComponent<Root>().Move(movement.ReadValue<Vector2>());
            waterResource.Value--;
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
    }

    public void SetRoot(int index)
    {
        selectedRoot = transform.GetChild(index).GetComponent<Root>();

    }
}
