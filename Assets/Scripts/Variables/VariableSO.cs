using System;
using UnityEngine;

public abstract class VariableSO<T> : ScriptableObject
{
    public abstract T Value
    {
        get;
        set;
    }

    public abstract Action<T> OnValueChanged { get; set; }

}
