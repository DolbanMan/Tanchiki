using UnityEngine;
using UnityEngine.Events;

public class EnemyShot : MonoBehaviour
{
    [SerializeField] private EnemyBullet _bulletTemplate;
    [SerializeField] private float _delayBetweenShoot;
    [SerializeField] private float _rayDistance;
   
    private float _timeAfterShoot;
    private Ray _ray;
    private bool _startPursuit=false;

    public UnityEvent IsPursuit;
    
    private void Update()
    {
        _timeAfterShoot += Time.deltaTime;

        _ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * _rayDistance, Color.red);

        RaycastHit hit;

        if(Physics.Raycast(_ray,out hit,_rayDistance)&& hit.collider.gameObject.TryGetComponent(out Player player))
        {

            _startPursuit = true;
            
            if (_timeAfterShoot >= _delayBetweenShoot)
            {
                CreationBullet();
                _timeAfterShoot = 0;
            }
        }
        if(_startPursuit)
        {
            IsPursuit.Invoke();
        }
    }

    public void CreationBullet()
    {
        Quaternion rotationSpawnPoint = transform.rotation;
        Instantiate(_bulletTemplate, transform.position, rotationSpawnPoint);
    }

}
