using UnityEngine;

public class Root : MonoBehaviour
{

    public void Move(Vector2 movement)
    {
        transform.position += new Vector3(movement.x*.1f,movement.y * .1f);
    }

}
