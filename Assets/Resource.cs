using UnityEngine;

public class Resource : MonoBehaviour
{
    [SerializeField] private IntVariableSO resource;
    [SerializeField] private int quantity;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        resource.Value += quantity;
        Destroy(gameObject);
    }
}
