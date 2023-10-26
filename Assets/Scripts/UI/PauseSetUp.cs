using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSetUp : MonoBehaviour
{
    [SerializeField] private GameObject pauseState;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            pauseState.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
