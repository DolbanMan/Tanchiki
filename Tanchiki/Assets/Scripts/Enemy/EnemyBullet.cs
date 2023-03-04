using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _dammage;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            player.ApplyDamage(_dammage);
        }
        Destroy(gameObject);
    }
}
