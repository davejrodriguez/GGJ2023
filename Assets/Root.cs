using UnityEngine;

public class Root : MonoBehaviour
{
    private LineRenderer line;

    private void Awake()
    {
        line = GetComponent<LineRenderer>();
    }

    public void Move(Vector2 movement)
    {
        line.positionCount++;
        line.SetPosition(line.positionCount-1,transform.position);
        line.Simplify(.05f);
        transform.position += new Vector3(movement.x*.1f,movement.y * .1f);
    }

    public void Split()
    {
        var splitRoot = Instantiate(gameObject,transform.position,transform.rotation,transform.parent).GetComponent<Root>();
        splitRoot.Move(transform.up+transform.right);
        Move(-transform.up-transform.right);
    }

}
