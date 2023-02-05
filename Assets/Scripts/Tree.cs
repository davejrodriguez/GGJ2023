using System.Collections;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] private FloatVariableSO health;
    [SerializeField] private FloatVariableSO shield;
    [SerializeField] private FloatVariableSO damageModifier;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private AnimationCurve damageCurve;

    private float round = 0;

    public void Damage(float baseDamage)
    {
        var modifiedDamage = baseDamage * damageModifier.Value;
        var damageAfterShield = modifiedDamage - shield.Value;
        shield.Value = Mathf.Clamp01(shield.Value - modifiedDamage);
        health.Value = Mathf.Clamp01(health.Value - damageAfterShield);
        StartCoroutine(DoDamageIndicator());
    }

    private IEnumerator DoDamageIndicator()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSecondsRealtime(.1f);
        spriteRenderer.color = Color.black;
    }

    public void OnGameStateChanged(int state)
    {
        if (state == 0)
        {
            StopAllCoroutines();
        }
        else
        {
            round += .001f;
            StartCoroutine(DamageLoop());
        }
    }

    IEnumerator DamageLoop()
    {
        Damage(damageCurve.Evaluate(round) * .001f);
        yield return new WaitForSecondsRealtime(1);
        StartCoroutine(DamageLoop());
    }

}
