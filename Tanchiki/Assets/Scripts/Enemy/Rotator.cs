using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _speedRotation;
    [SerializeField] private RoutePointsMovements _routePoints;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _speed;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Bullet>())
        {
            Rotation(_playerTransform);
        }
    }

    public void Rotation(Transform player)
    {
        transform.DOLookAt(player.position, _speedRotation, AxisConstraint.Y, Vector3.up);
        _routePoints.enabled = false;
    }
} 
