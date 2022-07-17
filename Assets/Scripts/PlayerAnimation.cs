using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : CharacterAnimatoin
{
    private readonly string _sittingAnimationName = "PlayerSit";

    public void StopCrawlAnimatoin(float duration)
    {
        SetPlaybackCrawlAnimation(false);
        StartCoroutine(StartingCrowlAnimatoin(duration));
        ParticlesAnimation.StartHitrintParticlesAnimation();
    }

    public void PlaySittingAnimation()
    {
        Animator.SetTrigger(_sittingAnimationName);
        ParticlesAnimation.SetPlaybackFootprintParticles(false);
    }
}
