using Cinemachine;
using UnityEngine;
using UnityEngine.Playables;
using DG.Tweening;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private readonly float _duration = 1f;
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    public void Move()
    {
        CinemachineBrain cinemachineBrain = _camera.GetComponent<CinemachineBrain>();
        _camera.transform.DOMove(_target.transform.position, _duration);
        _camera.transform.DORotate(_target.transform.rotation.eulerAngles, _duration);
        cinemachineBrain.enabled = false;
    }
}
