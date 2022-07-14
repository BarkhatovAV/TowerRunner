using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCollision : MonoBehaviour
{
    public event UnityAction Collided;
    public event UnityAction Finished;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out EnemyAnimatoin enemyAnimation))
        {
            Collided?.Invoke();
            enemyAnimation.PlayCollisionAnimatoin();
        }

        if (other.TryGetComponent(out Finish finish))
        {
            Finished?.Invoke();
        }
    }
}
