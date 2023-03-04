using UnityEngine;
using TMPro;

public class HealthPlayer : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthView;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.HealthUpdated += OnHealthUpdated;
    }

    private void OnDisable()
    {
        _player.HealthUpdated -= OnHealthUpdated;
    }

    private void OnHealthUpdated(int health)
    {
        _healthView.text = health.ToString();
    }
}
