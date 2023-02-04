using UnityEngine;

[ExecuteAlways]
[RequireComponent(typeof(TMPro.TextMeshProUGUI))]
public class VariableText<T> : MonoBehaviour
{
    [SerializeField] private VariableSO<T> variable;
    private TMPro.TextMeshProUGUI text;

    private void Awake()
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
    }

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
        text.text = variable.ToString();
    }

}
