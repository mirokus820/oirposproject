using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject Wintext; //obiekt przechowujący tekst o ukończeniu poziomu
    public Text timetext, retrytext; //obiekty przechowujące w formie tekstowej czas i liczbę prób ukonczenia poziomu
    private float starttime; //czas od rozpoczęcia działania aplikacji
    private bool finishlinereached; //czy meta została osiągnięta

    // Start is called before the first frame update
    void Start()
    {
        finishlinereached = false;
        starttime = Time.time; //czas dzialania aplikacji
        Wintext.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //jesli kulka dotarła do mety, zatrzymaj liczenie czasu
        if (finishlinereached)
            return;
        float t = Time.time - starttime; //czas od rozpoczecia liczenia czasu

        string minutes = ((int)t / 60).ToString(); //minuty
        string seconds = (t % 60).ToString("f2"); //sekundy z dwoma cyframi dziesietnymi

        timetext.text = "Time: " + minutes + ":" + seconds;
    }

    public void FinishLineReached()
    {
        finishlinereached = true;
        timetext.color = Color.green;
        retrytext.color = Color.green;
        Wintext.SetActive(true);
    }
}
