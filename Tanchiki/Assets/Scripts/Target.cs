using UnityEngine;
using UnityEngine.Events;

public class Target : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private ParticleSystem _dieParticle;

    public int Health => _health;

    public UnityEvent VictoryUpdated;

    public void ApplyDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            Die();
            VictoryUpdated.Invoke();
        }
        
    }

    public void Die()
    {
        Destroy(gameObject);
        Instantiate(_dieParticle, transform.position, Quaternion.Euler(-90,0,0));
    }
}
