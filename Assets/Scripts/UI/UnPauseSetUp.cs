using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UnPauseSetUp : MonoBehaviour
{
    [SerializeField] private Button exitPauseMenuButton;
    [SerializeField] private GameObject pauseMenuState;
    public void UnfreezeTime()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Restart() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    public void Leave() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    
}
