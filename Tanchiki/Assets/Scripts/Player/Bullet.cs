using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _damage;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            enemy.ApplyDamage(_damage);
        }
        if(collision.gameObject.TryGetComponent(out Target target))
        {
            target.ApplyDamage(_damage);
        }
        Destroy(gameObject);
    }

}
