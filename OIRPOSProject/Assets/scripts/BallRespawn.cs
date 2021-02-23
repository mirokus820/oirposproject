using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallRespawn : MonoBehaviour
{
    public GameObject spawnpoint;
    public GameObject map;
    public Text retrytext;
    private int retries;

    // Start is called before the first frame update
    void Start()
    {
        retries = 0;
        retrytext.text = "Retries: " + retries.ToString();
    }

    //przy kontakcie kulki z granicami mapy
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Ball")
        {
            
            GameObject.Find("Map").SendMessage("ResetRotation"); //powiadom mape o zresetowaniu polozenia
            other.transform.position = spawnpoint.transform.position; //zresetuj polozenie kulki

            retries += 1;
            retrytext.text = "Retries: "+ retries.ToString(); //uaktualnij liczbę prób ukończenia poziomu
        }
    }
}
