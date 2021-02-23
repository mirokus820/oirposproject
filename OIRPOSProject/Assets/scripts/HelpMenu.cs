using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMenu : MonoBehaviour
{
    public GameObject helpMenu;
    private bool ispaused;

    // Start is called before the first frame update
    void Start()
    {
        helpMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (ispaused) CloseHelpMenu(); //po nacisnieciu esc sprawdz czy gra jest wstrzymana i ją przywroc
            else ShowHelpMenu(); //jesli gra nie jest wstrzymana, wstrzymaj ją
        }
    }

    public void ShowHelpMenu()
    {
        helpMenu.SetActive(true); //wyswietl menu pauzy
        Time.timeScale = 0f; //zatrzymaj czas
        ispaused = true;
    }

    public void CloseHelpMenu()
    {
        helpMenu.SetActive(false); //ukryj menu pauzy
        Time.timeScale = 1f; //przywroc predkosc uplywu czasu
        ispaused = false;
    }
}
