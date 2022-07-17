using UnityEngine;

public class ParticlesAnimation : MonoBehaviour
{
    [SerializeField] private ParticleSystem _footprintParticles;
    [SerializeField] private ParticleSystem _hitParticles;

    public void SetPlaybackFootprintParticles(bool isPlaying)
    {
        if(isPlaying)
            _footprintParticles.Play();
        else
            _footprintParticles.Stop();
    }

    public void StartHitrintParticlesAnimation()
    {
        _hitParticles.Play();
    }
}
