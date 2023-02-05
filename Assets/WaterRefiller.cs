using UnityEngine;

public class WaterRefiller : MonoBehaviour
{
    [SerializeField] private IntVariableSO water;

    public void OnGameStateChanged(int state)
    {
        if(state==0)
        {
            water.Value += 500;
        }
    }

}
