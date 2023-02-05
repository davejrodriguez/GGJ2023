using UnityEngine;

public class LeafParticleSystem : MonoBehaviour
{

    [SerializeField] private ParticleSystem particles;

    private void Awake()
    {
        particles= GetComponent<ParticleSystem>();
    }

    public void OnGameStateChanged(int state)
    {
        if (state == 1)
        {
            particles.Play();
        }
        else
        {
            particles.Stop();
        }
    }

}
