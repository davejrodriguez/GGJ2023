using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public abstract class VariableListener<T> : MonoBehaviour
{

    public abstract VariableSO<T> Variable { get; }
    [SerializeField] private UnityEvent<T> OnVariableChanged;

    private void OnEnable()
    {
        if (Variable != null)
        {
            Variable.OnValueChanged += OnValueChanged;
        }
    }

    private void OnDisable()
    {
        if (Variable != null)
        {
            Variable.OnValueChanged -= OnValueChanged;
        }
    }

    private void OnValueChanged(T variable)
    {
        OnVariableChanged?.Invoke(variable);
    }

    private void OnValidate()
    {
        if (Variable != null)
        {
            Variable.OnValueChanged -= OnValueChanged;
            Variable.OnValueChanged += OnValueChanged;
        }
    }
}
