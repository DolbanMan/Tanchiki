using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    public event UnityAction<int> HealthUpdated;
    public UnityEvent LoseUpdated;

    private void Start()
    {
        HealthUpdated.Invoke(_health);
    }

    public void ApplyDamage(int damage)
    {
        _health -= damage;
        if(_health<=0)
        {
            Death();
            LoseUpdated.Invoke();
        }
        HealthUpdated.Invoke(_health);
    }

    private void Death()
    {
        Destroy(gameObject);
    }

}
