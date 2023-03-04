using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
   
    public void LoadScene(int NumberScene)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+NumberScene);
    }
}
