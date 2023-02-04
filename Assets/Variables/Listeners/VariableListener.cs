using UnityEngine;
using UnityEngine.Events;

[ExecuteAlways]
public class VariableListener<T> : MonoBehaviour
{

    [SerializeField] private VariableSO<T> variable;
    [SerializeField] private UnityEvent<T> OnVariableChanged;

    private void OnEnable()
    {
        if (variable != null)
        {
            variable.OnValueChanged += OnValueChanged;
        }
    }

    private void OnDisable()
    {
        if (variable != null)
        {
            variable.OnValueChanged -= OnValueChanged;
        }
    }

    private void OnValueChanged(T variable)
    {
        OnVariableChanged?.Invoke(variable);
    }

    private void OnValidate()
    {
        if (variable != null)
        {
            variable.OnValueChanged -= OnValueChanged;
            variable.OnValueChanged += OnValueChanged;
        }
    }
}
