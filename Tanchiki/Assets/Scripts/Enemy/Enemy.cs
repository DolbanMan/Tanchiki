using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private ParticleSystem _dieParticle;

    public void ApplyDamage(int damage)
    {
        _health -= damage;
        if(_health<=0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
        Instantiate(_dieParticle, transform.position, Quaternion.identity);
    }
     
}
