using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            GameObject.Find("Ball").SendMessage("FinishLineReached"); //powiadom gracza o osiągnięciu mety

            Debug.Log("you won");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
