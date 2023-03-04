using System.Collections.Generic;
using UnityEngine;

public class RoutePointsMovements : MonoBehaviour
{
    [SerializeField] private List<Transform> _points;
    [SerializeField] private float _speed;

    private int _currentPoint;

    private void Update()
    {
        Transform target = _points[_currentPoint];
        var direction = (target.position - transform.position).normalized;

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
        transform.LookAt(target);

        if (transform.position == target.position)
        {
            _currentPoint++;
            if (_currentPoint >= _points.Count)
            {
                _currentPoint = 0;
            }
        }
    }
}
