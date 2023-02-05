using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class TitleController : MonoBehaviour
{

    [SerializeField] private CanvasGroup group;

    public void PhaseOut()
    {
        StartCoroutine(DoPhaseOut());
    }
    private IEnumerator DoPhaseOut() { 
        while (group.alpha > 0)
        {
            group.alpha -= .005f;
            yield return new WaitForEndOfFrame();
        }
    }

}
