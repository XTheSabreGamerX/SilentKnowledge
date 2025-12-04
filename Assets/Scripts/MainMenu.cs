using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject controlsPanel;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Called by Quit Button
    public void QuitGame()
    {
        Application.Quit();
    }

    // Called by Controls Button
    public void OpenControls()
    {
        controlsPanel.SetActive(true);
    }

    // Called by Close Button inside Controls panel
    public void CloseControls()
    {
        controlsPanel.SetActive(false);
    }
}
