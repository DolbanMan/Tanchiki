using UnityEngine;
using DG.Tweening;

public class Pursuit : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _speedRotation;
    [SerializeField] private float _offset;

    private Player _player;
    private RoutePointsMovements _routePointsMovements;

    private void Start()
    {
        _player = GetComponent<Player>();
        _routePointsMovements = GetComponent<RoutePointsMovements>();
    }

    public void PursiutPlayer(Player player)
    {
        var target = player.transform.position;
        if(Vector3.Distance(transform.position,target)>_offset)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, _speed * Time.deltaTime);
            transform.DODynamicLookAt(target, _speedRotation, AxisConstraint.Y, Vector3.up);
            _routePointsMovements.enabled = false;
        }
    }
}
