using System.Collections;
using UnityEngine;

[RequireComponent(typeof(ParticlesAnimation))]
[RequireComponent(typeof(Animator))]
public class CharacterAnimatoin : MonoBehaviour
{
    protected Animator Animator;
    protected ParticlesAnimation ParticlesAnimation;

    private readonly float _maxDelayAnimation = 2f;
    private readonly float _minDelayAnimation = 0f;
    protected readonly string _crawlAnimation = "Crawl";
    private float _delay;

    private void Start()
    {
        ParticlesAnimation = GetComponent<ParticlesAnimation>();
        Animator = GetComponent<Animator>();
        _delay = Random.Range(_minDelayAnimation, _maxDelayAnimation);
        StartCoroutine(StartingCrowlAnimatoin(_delay));
    }

    protected void SetPlaybackCrawlAnimation(bool isPlaying)
    {
        Animator.SetBool(_crawlAnimation, isPlaying);
        ParticlesAnimation.SetPlaybackFootprintParticles(isPlaying);
    }

    protected IEnumerator StartingCrowlAnimatoin(float delay)
    {
        yield return new WaitForSeconds(delay);
        SetPlaybackCrawlAnimation(true);
        ParticlesAnimation.SetPlaybackFootprintParticles(true);
    }
}
