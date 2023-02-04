using UnityEngine;

public class Resource : MonoBehaviour
{
    [SerializeField] private IntVariableSO resource;
    [SerializeField] private int quantity;

    private void OnCollisionEnter(Collision collision)
    {
        resource.Value += quantity;
        Destroy(gameObject);
    }
}
