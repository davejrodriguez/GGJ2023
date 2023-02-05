using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] IntVariableSO gameState; //0 for root phase, 1 for wind phase

    public void BeginGame()
    {
        StartCoroutine(GameLoop());
    }

    IEnumerator GameLoop()
    {
        gameState.Value = 0;
        yield return new WaitForSecondsRealtime(5);
        gameState.Value = 1;
        yield return new WaitForSecondsRealtime(5);
        StartCoroutine(GameLoop());
    }

}
