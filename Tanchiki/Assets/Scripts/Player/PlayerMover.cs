using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _speedRotation;
    [SerializeField] private float _speedRotationTower;
    [SerializeField] private GameObject _tower;
    
    private void Update()
    {
        Move();
        RotateTower();
    }

    private void Move()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * _speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -_speedRotation * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, _speedRotation * Time.deltaTime);
        }
    }

    private void RotateTower()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            _tower.transform.Rotate(Vector3.up, -_speedRotationTower * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            _tower.transform.Rotate(Vector3.up, _speedRotationTower * Time.deltaTime);
        }
    }
}
