using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _VictoryMenu;
    [SerializeField] private GameObject _loseMenu;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void VictoryUpdated()
    {
        _VictoryMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void LoseActive()
    {
        _loseMenu.SetActive(true);
        Time.timeScale = 0;
    }
}
