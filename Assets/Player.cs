using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class Player : MonoBehaviour
{

    [SerializeField] private GameObject rootPrefab;

    List<Root> roots= new List<Root>();

    Root selectedRoot;

    private void Start()
    {
        selectedRoot = Instantiate(rootPrefab,transform).GetComponent<Root>();
    }

    public void Move(CallbackContext movement)
    {
        selectedRoot.Move(movement.ReadValue<Vector2>());
    }

    public void SelectLeftRoot(CallbackContext context)
    {
        //selected root equals the next left root or wrap to the rightmost root
    }

    public void SelectRightRoot(CallbackContext context)
    {
        //selected root equals the next right root or wrap to the leftmost root
    }
}
