using UnityEngine;

public class Mineral : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("root"))
        {
            collision.gameObject.GetComponent<Root>().Split();
            Destroy(gameObject);
        }
    }
}
