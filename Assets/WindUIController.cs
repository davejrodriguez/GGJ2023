using System.Collections;
using UnityEngine;

public class WindUIController : MonoBehaviour
{

    [SerializeField] private CanvasGroup group;

    public void PhaseIn()
    {
        StartCoroutine(DoPhaseIn());
    }

    public void PhaseOut()
    {
        StartCoroutine(DoPhaseOut());
    }
    private IEnumerator DoPhaseIn()
    {
        while (group.alpha < 1)
        {
            group.alpha += .005f;
            yield return new WaitForEndOfFrame();
        }
    }

    private IEnumerator DoPhaseOut()
    {
        while (group.alpha > 0)
        {
            group.alpha -= .005f;
            yield return new WaitForEndOfFrame();
        }
    }

    public void OnGameStateChanged(int state)
    {
        if(state==0)
        {
            PhaseOut();
        }
        else
        {
            PhaseIn();
        }
    }
}
