using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/Float", fileName = "NewFloatVariable.asset")]
public class FloatVariableSO : VariableSO<float>
{
    [SerializeField] private float _value;
    public override float Value { 
        get => _value; 
        set { 
            _value= value;
            OnValueChanged?.Invoke(value);
        } 
    }
    public override Action<float> OnValueChanged { get; set; }
}
