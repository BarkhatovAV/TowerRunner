using UnityEngine;

public class EnemyAnimatoin : CharacterAnimatoin
{
    private readonly string _kickAnimationName = "Kick";
    private readonly string _sittingAnimationName = "Sit";

    public void PlayCollisionAnimatoin()
    {
        Animator.SetTrigger(_kickAnimationName);
    }

    public void PlaySittingAnimation()
    {
        Animator.SetTrigger(_sittingAnimationName);
        ParticlesAnimation.StopFootprintParticlesAnimation();
    }

    public void StopAnimation()
    {
        StopCrawlAnimation();
    }
}
