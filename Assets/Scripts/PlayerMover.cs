using System.Collections;
using UnityEngine;
using DG.Tweening;
using System;

[RequireComponent(typeof(PlayerAnimation))]
[RequireComponent(typeof(PlayerCollision))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private TouchInput _touchInput;
    [SerializeField] private float _lateralVelocity;
    [SerializeField] private float _forwardVelocity;
    [SerializeField] private float _offsetAfterCollision;
    [SerializeField] private float _slidingTime;

    private PlayerAnimation _playerAnimation;
    private PlayerCollision _playerCollision;
    private Vector3 _moveDirection = new Vector3(1, 1, 1);
    private float _horizontalMove;
    private bool _isRunning = true;

    public event Action RiseFinished;
    public event Action FellDownStairs;

    private void Awake()
    {
        _playerCollision = GetComponent<PlayerCollision>();
        _playerAnimation = GetComponent<PlayerAnimation>();
    }

    private void OnEnable()
    {
        _touchInput.Touched += OnTouched;
        _playerCollision.Collided += OnCollided;
    }

    private void OnDisable()
    {
        _playerCollision.Collided -= OnCollided;
        _touchInput.Touched -= OnTouched;
    }

    public void StopMoving()
    {
        _isRunning = false;
        _playerAnimation.PlaySittingAnimation();
    }

    private void OnCollided()
    {
       _isRunning = false;
        transform.DOMoveX(transform.position.x - _offsetAfterCollision, _slidingTime);
        _playerAnimation.StopCrawlAnimatoin(_slidingTime);
        StartCoroutine(StopForwardMoving());
    }

    private IEnumerator StopForwardMoving()
    {
        yield return new WaitForSeconds(_slidingTime);
        _isRunning = true;
    }

    private void Update()
    {
        if (_isRunning)
        {
            _moveDirection = new Vector3(_horizontalMove * _lateralVelocity, 1, 0);
            transform.Translate(_moveDirection * _forwardVelocity * Time.deltaTime);
            _horizontalMove = 0;
        }
    }

    private void OnTouched(float value)
    {
        _horizontalMove += value;
    }
}
