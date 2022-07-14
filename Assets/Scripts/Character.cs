using UnityEngine;

[RequireComponent(typeof(EnemyMover))]
public class Character : MonoBehaviour
{
    private EnemyMover _enemyMover;

    private void Awake()
    {
        _enemyMover = GetComponent<EnemyMover>();
    }

    public void CelebrateVictory()
    {
        _enemyMover.StopMoving();
    }

    public void FallDown()
    {
        _enemyMover.MoveBack();
    }
}
