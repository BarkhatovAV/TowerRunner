using UnityEngine;

public class ParticlesAnimation : MonoBehaviour
{
    [SerializeField] private ParticleSystem _footprintParticles;
    [SerializeField] private ParticleSystem _hitParticles;

    public void StopFootprintParticlesAnimation()
    {
        _footprintParticles.Stop();
    }

    public void StartFootprintParticlesAnimation()
    {
        _footprintParticles.Play();
    }

    public void StartHitrintParticlesAnimation()
    {
        _hitParticles.Play();
    }
}
