using UnityEngine;

[RequireComponent(typeof(EnemyAnimatoin))]
public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _forwardVelocity;

    private EnemyAnimatoin _enemyAnimation;
    private Vector3 _moveDirection = new Vector3(0, 1, 0);
    private readonly Vector3 _movingBackRotation = new Vector3(-90, 0, 0);
    private readonly Vector3 _stopingMovementRotation = new Vector3(0, -180, 0);

    private void Awake()
    {
        _enemyAnimation = GetComponent<EnemyAnimatoin>();
    }

    private void Update()
    {
        transform.Translate(_moveDirection * _forwardVelocity * Time.deltaTime);
    }

    public void MoveBack()
    {
        _moveDirection = Vector3.back;
        transform.rotation = Quaternion.Euler(_movingBackRotation);
        _enemyAnimation.StopAnimation();
    }

    public void StopMoving()
    {
        transform.rotation = Quaternion.Euler(_stopingMovementRotation);
        _forwardVelocity = 0;
        _enemyAnimation.PlaySittingAnimation();
    }
}


