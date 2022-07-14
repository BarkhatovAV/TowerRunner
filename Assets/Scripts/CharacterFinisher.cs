using System.Collections.Generic;
using UnityEngine;

public class CharacterFinisher : MonoBehaviour
{
    [SerializeField] private List<EnemyMover> _enemyLosers;
    [SerializeField] private EnemyMover _firstEnemy;
    [SerializeField] private PlayerMover _player;
    [SerializeField] private EnemyMover _thirdEnemy;

    public void Finish(Vector3 firstPosition, Vector3 secondPosition, Vector3 thirdPosition)
    {
        DumpLosers();
        _firstEnemy.transform.position = firstPosition;
        _firstEnemy.StopMoving();
        _player.transform.position = secondPosition;
        _player.StopMoving();
        _thirdEnemy.transform.position = thirdPosition;
        _thirdEnemy.StopMoving();
    }

    private void DumpLosers()
    {
        foreach (EnemyMover enemyLoser in _enemyLosers)
        {
            enemyLoser.MoveBack();
        }
    }
}
