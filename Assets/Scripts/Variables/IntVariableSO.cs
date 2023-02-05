using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/Int", fileName = "NewIntVariable.asset")]
public class IntVariableSO : VariableSO<int>
{
    [SerializeField] private int _value;
    public override int Value { 
        get => _value; 
        set { 
            _value= value;
            OnValueChanged?.Invoke(value);
        } 
    }
    public override Action<int> OnValueChanged { get; set; }
}
