using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool ispaused;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused) ResumeGame(); //po nacisnieciu esc sprawdz czy gra jest wstrzymana i ją przywroc
            else PauseGame(); //jesli gra nie jest wstrzymana, wstrzymaj ją
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true); //wyswietl menu pauzy
        Time.timeScale = 0f; //zatrzymaj czas
        ispaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false); //ukryj menu pauzy
        Time.timeScale = 1f; //przywroc predkosc uplywu czasu
        ispaused = false;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main menu");
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying=false;
#else
        Application.Quit();
#endif
    }
}
