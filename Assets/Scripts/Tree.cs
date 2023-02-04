using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] private Branch branch;

    private void Start()
    {
        branch.BranchIt(5);
    }

}
