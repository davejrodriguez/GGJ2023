using UnityEngine;

public class Branch : MonoBehaviour
{

    public void BranchIt(int levels)
    {
        if (levels > 0)
        {
            Instantiate(gameObject, transform.up, transform.rotation * Quaternion.Euler(0f, -30f, 0f), transform).GetComponent<Branch>().BranchIt(levels - 1);
            Instantiate(gameObject, transform.up, transform.rotation * Quaternion.Euler(0f, 30f, 0f), transform).GetComponent<Branch>().BranchIt(levels - 1);
        }
    }

}