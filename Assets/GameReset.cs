using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.InputSystem.InputAction;

public class GameReset : MonoBehaviour
{
    [SerializeField] private IntVariableSO water;
    [SerializeField] private IntVariableSO nutrients;
    [SerializeField] private IntVariableSO gameState;
    [SerializeField] private FloatVariableSO health;
    [SerializeField] private FloatVariableSO shield;
    [SerializeField] private FloatVariableSO damageModifier;
    public void Reset(CallbackContext context)
    {
        water.Value = 1000;
        nutrients.Value = 0;
        gameState.Value = 0;
        health.Value = 1;
        shield.Value = 0;
        damageModifier.Value = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name,LoadSceneMode.Single);
    }
}
