using UnityEngine;

public class Mineral : MonoBehaviour
{
    [SerializeField] private FloatVariableSO resource;
    [SerializeField] private float quantity;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        resource.Value += quantity;
        Destroy(gameObject);
    }
}
