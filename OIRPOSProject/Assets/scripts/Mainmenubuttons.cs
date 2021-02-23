using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenubuttons : MonoBehaviour
{
    public GameObject menuPanel, levelSelect;
    // Start is called before the first frame update
    void Start()
    {
        menuPanel.SetActive(true);
        levelSelect.SetActive(false);
    }

    public void ShowMenuPanel()
    {
        menuPanel.SetActive(true);
        levelSelect.SetActive(false);
    }

    public void ShowLevelPanel()
    {
        menuPanel.SetActive(false);
        levelSelect.SetActive(true);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying=false;
#else
        Application.Quit();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
