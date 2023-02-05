using System;
using UnityEngine;

public class IntVariableListener : VariableListener<int>
{
    [SerializeField] private IntVariableSO variable;
    public override VariableSO<int> Variable { get => variable; }
}
