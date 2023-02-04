using System;
using UnityEngine;

public class VariableSO<T> : ScriptableObject
{
    [SerializeField]private T _value;
    public T Value
    {
        get => _value;
        set
        {
            _value = value;
            OnValueChanged?.Invoke(value);
        }
    }

    public Action<T> OnValueChanged { get; set; }

    private void OnValidate()
    {
        Value= _value;
    }

}
