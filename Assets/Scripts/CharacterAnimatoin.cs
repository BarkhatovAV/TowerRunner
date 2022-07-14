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

    protected void PlayCrawlAnimation()
    {
        Animator.SetBool(_crawlAnimation, true);
        ParticlesAnimation.StartFootprintParticlesAnimation();
    }

    protected void StopCrawlAnimation()
    {
        Animator.SetBool(_crawlAnimation, false);
        ParticlesAnimation.StopFootprintParticlesAnimation();
    }

    protected IEnumerator StartingCrowlAnimatoin(float delay)
    {
        yield return new WaitForSeconds(delay);
        PlayCrawlAnimation();
        ParticlesAnimation.StartFootprintParticlesAnimation();
    }
}
