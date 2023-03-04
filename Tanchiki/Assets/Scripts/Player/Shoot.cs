using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Bullet _bulletTemplate;
    [SerializeField] private float _delayBetweenShoot;
  
    private float _timeAfterShoot;

    private void Update()
    {
        _timeAfterShoot += Time.deltaTime;

        if(Input.GetMouseButtonDown(0))
        {
            if(_timeAfterShoot>_delayBetweenShoot)
            {
                CreationBullet();
                _timeAfterShoot = 0;
            }
        }
    }

    private void CreationBullet()
    {
        Quaternion rotationSpawnPoint = transform.rotation;
        Instantiate(_bulletTemplate, transform.position, rotationSpawnPoint);
    }
}
