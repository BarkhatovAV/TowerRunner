using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private CameraMovement _cameraMovement;
    [SerializeField] private PlayerCollision _playerCollision;
    [SerializeField] private CharacterFinisher _characters;
    [SerializeField] private Transform _firstPlace;
    [SerializeField] private Transform _secondPlace;
    [SerializeField] private Transform _thirdPlace;
    [SerializeField] private ParticleSystem _particle;

    private void OnEnable()
    {
        _playerCollision.Finished += OnFinished;
    }

    private void OnDisable()
    {
        _playerCollision.Finished -= OnFinished;
    }

    private void OnFinished()
    {
        _characters.Finish(_firstPlace.position, _secondPlace.position, _thirdPlace.position);
        _cameraMovement.Move();
        _particle.Play();
    }
}
