using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtonsSettings : MonoBehaviour
{
    public void OnStartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LeaveFromTheGameButton()
    {
        Application.Quit();
    }
}
