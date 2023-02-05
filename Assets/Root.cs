using Cinemachine;
using UnityEngine;

public class Root : MonoBehaviour
{
    private LineRenderer line;
    CinemachineVirtualCamera cam;
    SpriteRenderer renderer;

    private void Awake()
    {
        renderer= GetComponent<SpriteRenderer>();
        line = GetComponent<LineRenderer>();
        line.positionCount= 1;
        line.SetPosition(0,transform.position);
        cam= GetComponentInChildren<CinemachineVirtualCamera>();
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

    public void Select()
    {
        renderer.enabled = true;
    }

    public void Deselect()
    {
        renderer.enabled = false;
    }

    public void GoLive()
    {
        cam.MoveToTopOfPrioritySubqueue();
    }

}
