using UnityEngine;

public class FloatVariableListener : VariableListener<float>
{
    [SerializeField] private FloatVariableSO variable;
    public override VariableSO<float> Variable { get => variable; }
}
