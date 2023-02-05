using System.Collections;
using UnityEngine;

public class WindAudioController : MonoBehaviour
{
    AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

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
        while (source.volume < 1)
        {
            source.volume += .001f;
            yield return new WaitForEndOfFrame();
        }
    }

    private IEnumerator DoPhaseOut()
    {
        while (source.volume > .25f)
        {
            source.volume -= .001f;
            yield return new WaitForEndOfFrame();
        }
    }

    public void OnGameStateChanged(int state)
    {
        if (state == 0)
        {
            PhaseOut();
        }
        else
        {
            PhaseIn();
        }
    }
}
